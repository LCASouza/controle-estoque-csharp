using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
	public partial class FirstUse : Form
	{
		public static bool conectado=true;

		public FirstUse()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string chaveP = "Ah5=G972";
			string chaveS = "64A-b925";

			if (userLine.Text=="" || passwdLine.Text=="" || databaseLine.Text=="")
			{
				MessageBox.Show("Insira todos os dados corretamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				string user = userLine.Text;
				string pwd = passwdLine.Text, pwdC;
				string database = databaseLine.Text;

				try{
					byte[] secretkeyByte = { };
					secretkeyByte = System.Text.Encoding.UTF8.GetBytes(chaveS);
					byte[] publickeybyte = { };
					publickeybyte = System.Text.Encoding.UTF8.GetBytes(chaveP);
					MemoryStream ms = null;
					CryptoStream cs = null;
					byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(pwd);
					using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
					{
						ms = new MemoryStream();
						cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
						cs.Write(inputbyteArray, 0, inputbyteArray.Length);
						cs.FlushFinalBlock();
						pwdC = Convert.ToBase64String(ms.ToArray());
					}
				}
				catch(Exception exp)
				{
					throw new Exception(exp.Message, exp.InnerException);
				}
				
				using (FileStream fs = new FileStream("bConnect.bin", FileMode.CreateNew))
				{
					using (BinaryWriter writer = new BinaryWriter(fs))
					{
						writer.Write(user);
						writer.Write(pwdC);
						writer.Write(database);

						conectado = true;

						Close();
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			conectado = false;
			Close();
		}
	}
}
