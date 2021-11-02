using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Estoque
{
	public partial class JanelaInfoItem : Form
	{
		private string idP = "";
		private string t = "";
		public static bool alt;
		public static bool ins;

		public JanelaInfoItem(string id, string tipo)
		{
			InitializeComponent();

			idP = id;
			t = tipo;
			alt = false;
			ins = false;

			if (tipo == "visualizar")
			{
				nomeLine.ReadOnly = true;
				marcaLine.ReadOnly = true;
				valorLine.ReadOnly = true;
				custoLine.ReadOnly = true;
				quantLine.ReadOnly = true;

				this.Text = "Informação do produto";
				carregar();
			}
			else if (tipo == "alterar")
			{
				carregar();
			}
			else if (tipo == "inserir")
			{
				this.Text = "Inserir produto";
			}
		}

		private void tratarEntrada(KeyPressEventArgs e, TextBox campo)
		{
			if (e.KeyChar == '.' || e.KeyChar == ',')
			{
				e.KeyChar = '.';

				if (campo.Text.Contains("."))
				{
					e.Handled = true;
				}
			}
			else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
			{
				e.Handled = true;
			}
		}

		private void carregar()
		{
			if (idP != "" && t == "visualizar")
			{
				MySqlCommand query = new MySqlCommand("SELECT * FROM produtos WHERE id = '" + idP + "';", Program.connect);
				MySqlDataReader rd;

				Program.connect.Open();

				rd = query.ExecuteReader();

				if (rd.Read())
				{
					nomeLine.Text = rd["nome"].ToString();
					marcaLine.Text = rd["marca"].ToString();
					quantLine.Text = rd["quantidade"].ToString();
					valorLine.Text = "R$ "+Convert.ToString(rd["valor"]);
					custoLine.Text = "R$ "+Convert.ToString(rd["custo"]);
				}
				Program.connect.Close();
			}
			else if (idP != "" && t == "alterar")
			{
				MySqlCommand query = new MySqlCommand("SELECT * FROM produtos WHERE id = '" + idP + "';", Program.connect);
				MySqlDataReader rd;

				Program.connect.Open();

				rd = query.ExecuteReader();

				if (rd.Read())
				{
					nomeLine.Text = rd["nome"].ToString();
					marcaLine.Text = rd["marca"].ToString();
					quantLine.Text = rd["quantidade"].ToString();
					valorLine.Text = Convert.ToString(rd["valor"], CultureInfo.InvariantCulture);
					custoLine.Text = Convert.ToString(rd["custo"], CultureInfo.InvariantCulture);
				}
				Program.connect.Close();
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string nome = nomeLine.Text;
			string marca = marcaLine.Text;
			string valor = valorLine.Text;
			string custo = custoLine.Text;
			string quantidade = quantLine.Text;

			if (nome == "" || marca == "" || valor == "" || custo == "" || quantidade == "")
			{
				MessageBox.Show("Preencha todos os campos adequadamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (t=="inserir")
			{
				if (nome == "" || marca == "" || valor == "" || custo == "" || quantidade == "")
				{
					MessageBox.Show("Preencha todos os campos adequadamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					DialogResult escolha = new DialogResult();
					escolha = MessageBox.Show("Salvar produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (escolha == DialogResult.Yes)
					{
						MySqlCommand query = new MySqlCommand("INSERT INTO produtos (nome, marca, valor, custo, quantidade)" +
																"VALUES ('" + nome + "', '" + marca + "', '" + valor + "', '" + custo + "', '" + quantidade + "');", Program.connect);
						Program.connect.Open();

						query.ExecuteNonQuery();

						MessageBox.Show("O Produto foi Salvo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ins = true;

						Program.connect.Close();
						Close();
					}
				}
			}
			else if (idP!="" && t == "alterar")
			{
				DialogResult escolha = new DialogResult();
				escolha = MessageBox.Show("Salvar produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (escolha == DialogResult.Yes && idP != "")
				{
					MySqlCommand query = new MySqlCommand("UPDATE produtos SET nome = '" + nome + "', marca = '" + marca + "', valor ='" + valor + "', custo ='" + custo + "', " +
						"quantidade ='" + quantidade + "' WHERE id = '" + idP + "';", Program.connect);

					Program.connect.Open();

					query.ExecuteNonQuery();

					MessageBox.Show("O Produto foi Salvo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					alt = true;

					Program.connect.Close();
					Close();
				}
			}
			else if (idP != "" && t == "visualizar")
			{
				Close();
			}
		}

		private void valorKeyLine(object sender, KeyPressEventArgs e)
		{
			tratarEntrada(e, valorLine);
		}

		private void custoKeyLine(object sender, KeyPressEventArgs e)
		{
			tratarEntrada(e, custoLine);
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
