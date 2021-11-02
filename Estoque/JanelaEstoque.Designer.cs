
namespace Estoque
{
	partial class JanelaEstoque
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaEstoque));
			this.nameLine = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.removerButton = new System.Windows.Forms.Button();
			this.quitButton = new System.Windows.Forms.Button();
			this.inserirButton = new System.Windows.Forms.Button();
			this.listProducts = new System.Windows.Forms.ListView();
			this.cID = new System.Windows.Forms.ColumnHeader();
			this.cNome = new System.Windows.Forms.ColumnHeader();
			this.cMarca = new System.Windows.Forms.ColumnHeader();
			this.cValor = new System.Windows.Forms.ColumnHeader();
			this.cCusto = new System.Windows.Forms.ColumnHeader();
			this.cQuantidade = new System.Windows.Forms.ColumnHeader();
			this.alterarButton = new System.Windows.Forms.Button();
			this.entradaButton = new System.Windows.Forms.Button();
			this.saidaButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameLine
			// 
			this.nameLine.Location = new System.Drawing.Point(564, 19);
			this.nameLine.Name = "nameLine";
			this.nameLine.Size = new System.Drawing.Size(469, 23);
			this.nameLine.TabIndex = 3;
			this.nameLine.TextChanged += new System.EventHandler(this.nameSearch);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nameLabel.Location = new System.Drawing.Point(517, 20);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(41, 17);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "Busca";
			// 
			// removerButton
			// 
			this.removerButton.Location = new System.Drawing.Point(285, 12);
			this.removerButton.Name = "removerButton";
			this.removerButton.Size = new System.Drawing.Size(100, 35);
			this.removerButton.TabIndex = 13;
			this.removerButton.Text = "REMOVER";
			this.removerButton.UseVisualStyleBackColor = true;
			this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
			// 
			// quitButton
			// 
			this.quitButton.Location = new System.Drawing.Point(1472, 12);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(100, 35);
			this.quitButton.TabIndex = 12;
			this.quitButton.Text = "SAIR";
			this.quitButton.UseVisualStyleBackColor = true;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// inserirButton
			// 
			this.inserirButton.Location = new System.Drawing.Point(73, 12);
			this.inserirButton.Name = "inserirButton";
			this.inserirButton.Size = new System.Drawing.Size(100, 35);
			this.inserirButton.TabIndex = 11;
			this.inserirButton.Text = "INSERIR";
			this.inserirButton.UseVisualStyleBackColor = true;
			this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
			// 
			// listProducts
			// 
			this.listProducts.BackColor = System.Drawing.SystemColors.Window;
			this.listProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cNome,
            this.cMarca,
            this.cValor,
            this.cCusto,
            this.cQuantidade});
			this.listProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.listProducts.FullRowSelect = true;
			this.listProducts.HideSelection = false;
			this.listProducts.Location = new System.Drawing.Point(12, 65);
			this.listProducts.MultiSelect = false;
			this.listProducts.Name = "listProducts";
			this.listProducts.Size = new System.Drawing.Size(1560, 784);
			this.listProducts.TabIndex = 14;
			this.listProducts.UseCompatibleStateImageBehavior = false;
			this.listProducts.View = System.Windows.Forms.View.Details;
			this.listProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemClicked);
			// 
			// cID
			// 
			this.cID.Text = "ID";
			this.cID.Width = 70;
			// 
			// cNome
			// 
			this.cNome.Text = "Nome";
			this.cNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cNome.Width = 600;
			// 
			// cMarca
			// 
			this.cMarca.Text = "Marca";
			this.cMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cMarca.Width = 300;
			// 
			// cValor
			// 
			this.cValor.Text = "Valor";
			this.cValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cValor.Width = 200;
			// 
			// cCusto
			// 
			this.cCusto.Text = "Custo";
			this.cCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cCusto.Width = 200;
			// 
			// cQuantidade
			// 
			this.cQuantidade.Text = "Quantidade";
			this.cQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cQuantidade.Width = 185;
			// 
			// alterarButton
			// 
			this.alterarButton.Location = new System.Drawing.Point(179, 12);
			this.alterarButton.Name = "alterarButton";
			this.alterarButton.Size = new System.Drawing.Size(100, 35);
			this.alterarButton.TabIndex = 15;
			this.alterarButton.Text = "ALTERAR";
			this.alterarButton.UseVisualStyleBackColor = true;
			this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
			// 
			// entradaButton
			// 
			this.entradaButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.entradaButton.Location = new System.Drawing.Point(1175, 12);
			this.entradaButton.Name = "entradaButton";
			this.entradaButton.Size = new System.Drawing.Size(100, 35);
			this.entradaButton.TabIndex = 16;
			this.entradaButton.Text = "ENTRADA DE PRODUTOS";
			this.entradaButton.UseVisualStyleBackColor = true;
			this.entradaButton.Click += new System.EventHandler(this.entradaButton_Click);
			// 
			// saidaButton
			// 
			this.saidaButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.saidaButton.Location = new System.Drawing.Point(1281, 12);
			this.saidaButton.Name = "saidaButton";
			this.saidaButton.Size = new System.Drawing.Size(100, 35);
			this.saidaButton.TabIndex = 17;
			this.saidaButton.Text = "SAIDA DE PRODUTOS";
			this.saidaButton.UseVisualStyleBackColor = true;
			this.saidaButton.Click += new System.EventHandler(this.saidaButton_Click);
			// 
			// JanelaEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 861);
			this.Controls.Add(this.saidaButton);
			this.Controls.Add(this.entradaButton);
			this.Controls.Add(this.alterarButton);
			this.Controls.Add(this.listProducts);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.inserirButton);
			this.Controls.Add(this.removerButton);
			this.Controls.Add(this.nameLine);
			this.Controls.Add(this.quitButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1600, 900);
			this.MinimumSize = new System.Drawing.Size(1600, 900);
			this.Name = "JanelaEstoque";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Estoque";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox nameLine;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button inserirButton;
		private System.Windows.Forms.Button removerButton;
		private System.Windows.Forms.Button quitButton;
		private System.Windows.Forms.ListView listProducts;
		private System.Windows.Forms.ColumnHeader cID;
		private System.Windows.Forms.ColumnHeader cNome;
		private System.Windows.Forms.ColumnHeader cMarca;
		private System.Windows.Forms.ColumnHeader cQuantidade;
		private System.Windows.Forms.ColumnHeader cValor;
		private System.Windows.Forms.ColumnHeader cCusto;
		private System.Windows.Forms.Button alterarButton;
		private System.Windows.Forms.Button entradaButton;
		private System.Windows.Forms.Button saidaButton;
	}
}

