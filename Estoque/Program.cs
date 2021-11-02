using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Estoque
{
	static class Program
	{
		public static MySqlConnection connect = new MySqlConnection();
		private static string user;
		private static string psswd, psswdD;
		private static string database;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]

		static bool first()
		{
			try
			{
				using (FileStream fs = new FileStream("bConnect.bin", FileMode.Open, FileAccess.Read))
				{
					using (BinaryReader reader = new BinaryReader(fs))
					{
						user = reader.ReadString();
						psswd = reader.ReadString();
						database = reader.ReadString();
					}
				}
			}
			catch
			{
				FirstUse janela = new FirstUse();
				janela.ShowDialog();

				if (!FirstUse.conectado)
				{
					return false;
				}

				using (FileStream fs = new FileStream("bConnect.bin", FileMode.Open, FileAccess.Read))
				{
					using (BinaryReader reader = new BinaryReader(fs))
					{
						user = reader.ReadString();
						psswd = reader.ReadString();
						database = reader.ReadString();
					}
				}
			}

			try
			{
				string publickey = "Ah5=G972";
				string secretkey = "64A-b925";
				byte[] privatekeyByte = { };
				privatekeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
				byte[] publickeybyte = { };
				publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
				MemoryStream ms = null;
				CryptoStream cs = null;
				byte[] inputbyteArray = new byte[psswd.Replace(" ", "+").Length];
				inputbyteArray = Convert.FromBase64String(psswd.Replace(" ", "+"));
				using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
				{
					ms = new MemoryStream();
					cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
					cs.Write(inputbyteArray, 0, inputbyteArray.Length);
					cs.FlushFinalBlock();
					Encoding encoding = Encoding.UTF8;
					psswdD = encoding.GetString(ms.ToArray());
				}
			}
			catch (Exception exp)
			{
				throw new Exception(exp.Message, exp.InnerException);
			}

			return true;
		}

		static bool tryConnection()
		{
			try
			{
				connect.ConnectionString = "server=localhost;database='"+database+"';uid='"+user+"';pwd='"+psswdD+"';port=3306";
				connect.Open();
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.ToString());
				return false;
			}
			return true;
		}
		static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(false);
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();


			if (!first())
			{
				return;
			}
			if (!tryConnection())
			{
				MessageBox.Show("Erro ao conectar ao banco de dados.\n" +
					"Tente deletar o arquivo bConnect.bin na pasta do programa e execute o programa novamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			connect.Close();
			
			Application.Run(new JanelaLogin());

			if (!JanelaLogin.connected)
			{
				return;
			}
			

			Application.Run(new JanelaEstoque());
		}
	}
}
