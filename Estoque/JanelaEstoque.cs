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
	public partial class JanelaEstoque : Form
	{
		public JanelaEstoque()
		{
			InitializeComponent();

			inicio();
		}

		private void search(string text)
		{
			MySqlCommand query = new MySqlCommand("SELECT * FROM produtos WHERE CONCAT_WS('', id, nome, marca) LIKE CONCAT ('%', '" + text + "', '%');", Program.connect);
			MySqlDataReader rd;

			Program.connect.Open();

			rd = query.ExecuteReader();

			executeReader(rd);
			Program.connect.Close();
		}

		private void executeReader(MySqlDataReader rd)
		{
			listProducts.Items.Clear();
			while (rd.Read())
			{
				string[] data = new string[6];
				data[0] = rd["id"].ToString();
				data[1] = rd["nome"].ToString();
				data[2] = rd["marca"].ToString();
				data[3] = "R$ "+Convert.ToString(rd["valor"], CultureInfo.InvariantCulture);
				data[4] = "R$ "+Convert.ToString(rd["custo"], CultureInfo.InvariantCulture);
				data[5] = rd["quantidade"].ToString();
				//data[6] = rd["entradas"].ToString();
				//data[7] = rd["saidas"].ToString();

				ListViewItem item = new ListViewItem(data);
				listProducts.Items.Add(item);
			}
		}

		private void inicio()
		{
			MySqlCommand query = new MySqlCommand("SELECT * FROM produtos;", Program.connect);
			MySqlDataReader rd;

			Program.connect.Open();

			rd = query.ExecuteReader();

			executeReader(rd);

			Program.connect.Close();
		}

		private void nameSearch(object sender, EventArgs e)
		{
			string name = nameLine.Text;

			search(name);
		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void inserirButton_Click(object sender, EventArgs e)
		{
			JanelaInfoItem inserir = new JanelaInfoItem("", "inserir");

			inserir.ShowDialog();

			if (JanelaInfoItem.ins)
			{
				inicio();
				JanelaInfoItem.ins = false;
			}
		}

		private void removerButton_Click(object sender, EventArgs e)
		{
			string id;
			if (listProducts.SelectedItems.Count>0)
			{
				id = listProducts.SelectedItems[0].SubItems[0].Text;

				string nome = listProducts.SelectedItems[0].SubItems[1].Text;

				DialogResult escolha = new DialogResult();
				escolha = MessageBox.Show("Remover o produto '" + nome + "'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (escolha == DialogResult.Yes)
				{
					MySqlCommand query = new MySqlCommand("DELETE FROM produtos WHERE id = '" + id + "';", Program.connect);

					Program.connect.Open();
					query.ExecuteNonQuery();
					listProducts.Items.RemoveAt(listProducts.SelectedIndices[0]);
					Program.connect.Close();

					MessageBox.Show("Produto removido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void alterarButton_Click(object sender, EventArgs e)
		{
			string id;
			if (listProducts.SelectedItems.Count > 0)
			{
				id = listProducts.SelectedItems[0].SubItems[0].Text;

				JanelaInfoItem info = new JanelaInfoItem(id, "alterar");

				info.ShowDialog();

				if (JanelaInfoItem.alt)
				{
					inicio();
					JanelaInfoItem.ins = false;
				}
			}
		}

		private void itemClicked(object sender, MouseEventArgs e)
		{
			string id = listProducts.SelectedItems[0].SubItems[0].Text;

			JanelaInfoItem info = new JanelaInfoItem(id, "visualizar");

			info.ShowDialog();
		}

		private void entradaButton_Click(object sender, EventArgs e)
		{
			string id, quant;
			if (listProducts.SelectedItems.Count > 0)
			{
				id = listProducts.SelectedItems[0].SubItems[0].Text;
				quant = listProducts.SelectedItems[0].SubItems[5].Text;

				registro reg = new registro(id, quant, "entrada");

				reg.ShowDialog();

				if (registro.saved)
				{
					inicio();
					registro.saved = false;
				}
			}
		}

		private void saidaButton_Click(object sender, EventArgs e)
		{
			string id, quant;
			if (listProducts.SelectedItems.Count > 0)
			{
				id = listProducts.SelectedItems[0].SubItems[0].Text;
				quant = listProducts.SelectedItems[0].SubItems[5].Text;

				registro reg = new registro(id, quant, "saida");

				reg.ShowDialog();

				if (registro.saved)
				{
					inicio();
					registro.saved = false;
				}
			}
		}
	}
}
