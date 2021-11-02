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
	public partial class registro : Form
	{
		private string quantDB="";
		private string idP="";
		private string t="";
		static public bool saved;
		public registro(string id, string quant, string tipo)
		{
			InitializeComponent();

			saved = false;
			idP = id;
			t = tipo;
			quantDB = quant;

			if (tipo == "entrada")
			{
				this.Text = "Adicionar Quantidade";
			}
			else if (tipo == "saida")
			{
				this.Text = "Remover Quantidade";
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string quantidade = quantLine.Text;

			if (t=="entrada")
			{
				if (quantDB != "")
				{
					quantidade = (Convert.ToInt32(quantDB) + Convert.ToInt32(quantidade)).ToString();

					DialogResult escolha = new DialogResult();
					escolha = MessageBox.Show("Inserir quantidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (escolha == DialogResult.Yes && idP != "")
					{
						MySqlCommand query = new MySqlCommand("UPDATE produtos SET quantidade ='" + quantidade + "' WHERE id = '" + idP + "';", Program.connect);

						Program.connect.Open();

						query.ExecuteNonQuery();

						MessageBox.Show("Quantidade Atualizada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						saved = true;

						Program.connect.Close();
						Close();
					}
				}
			}
			else if (t=="saida")
			{
				if (quantDB!="")
				{
					quantidade = (Convert.ToInt32(quantDB) - Convert.ToInt32(quantidade)).ToString();

					DialogResult escolha = new DialogResult();
					escolha = MessageBox.Show("Remover quantidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (escolha == DialogResult.Yes && idP != "")
					{
						MySqlCommand query = new MySqlCommand("UPDATE produtos SET quantidade ='" + quantidade + "' WHERE id = '" + idP + "';", Program.connect);

						Program.connect.Open();

						query.ExecuteNonQuery();

						MessageBox.Show("Quantidade Atualizada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						saved = true;

						Program.connect.Close();
						Close();
					}
				}
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void quantKeyLine(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
			{
				e.Handled = true;
			}
		}
	}
}
