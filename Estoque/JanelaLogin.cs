using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Estoque
{
	public partial class JanelaLogin : Form
	{
		public static bool connected = false;

		public JanelaLogin()
		{
			InitializeComponent();
		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			connected = false;
			Close();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			string userText = userLine.Text;
			string pwd = passwdLine.Text;

			try
			{
				MySqlCommand query = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = '" + userText + "' and senha = '" + pwd + "';", Program.connect);
				MySqlDataReader rd;

				Program.connect.Open();

				rd = query.ExecuteReader();

				if (rd.Read())
				{
					connected = true;
					Program.connect.Close();
					Close();
				}
				else
				{
					MessageBox.Show("Usuario ou Senha incorreto!", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				Program.connect.Close();
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.ToString());
			}
		}
	}
}
