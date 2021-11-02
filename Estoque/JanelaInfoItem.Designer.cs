
namespace Estoque
{
	partial class JanelaInfoItem
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaInfoItem));
			this.custoLine = new System.Windows.Forms.TextBox();
			this.valorLine = new System.Windows.Forms.TextBox();
			this.quantLine = new System.Windows.Forms.TextBox();
			this.quantLabel = new System.Windows.Forms.Label();
			this.marcaLine = new System.Windows.Forms.TextBox();
			this.nomeLine = new System.Windows.Forms.TextBox();
			this.custoLabel = new System.Windows.Forms.Label();
			this.valorLabel = new System.Windows.Forms.Label();
			this.marcaLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// custoLine
			// 
			this.custoLine.Location = new System.Drawing.Point(283, 94);
			this.custoLine.MaxLength = 8;
			this.custoLine.Name = "custoLine";
			this.custoLine.Size = new System.Drawing.Size(115, 23);
			this.custoLine.TabIndex = 19;
			this.custoLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custoKeyLine);
			// 
			// valorLine
			// 
			this.valorLine.Location = new System.Drawing.Point(71, 94);
			this.valorLine.MaxLength = 8;
			this.valorLine.Name = "valorLine";
			this.valorLine.Size = new System.Drawing.Size(112, 23);
			this.valorLine.TabIndex = 18;
			this.valorLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorKeyLine);
			// 
			// quantLine
			// 
			this.quantLine.Location = new System.Drawing.Point(283, 58);
			this.quantLine.MaxLength = 6;
			this.quantLine.Name = "quantLine";
			this.quantLine.Size = new System.Drawing.Size(115, 23);
			this.quantLine.TabIndex = 17;
			this.quantLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantKeyLine);
			// 
			// quantLabel
			// 
			this.quantLabel.AutoSize = true;
			this.quantLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.quantLabel.Location = new System.Drawing.Point(201, 59);
			this.quantLabel.Name = "quantLabel";
			this.quantLabel.Size = new System.Drawing.Size(76, 17);
			this.quantLabel.TabIndex = 16;
			this.quantLabel.Text = "Quantidade";
			// 
			// marcaLine
			// 
			this.marcaLine.Location = new System.Drawing.Point(71, 57);
			this.marcaLine.MaxLength = 25;
			this.marcaLine.Name = "marcaLine";
			this.marcaLine.Size = new System.Drawing.Size(112, 23);
			this.marcaLine.TabIndex = 15;
			// 
			// nomeLine
			// 
			this.nomeLine.Location = new System.Drawing.Point(71, 21);
			this.nomeLine.MaxLength = 70;
			this.nomeLine.Name = "nomeLine";
			this.nomeLine.Size = new System.Drawing.Size(327, 23);
			this.nomeLine.TabIndex = 14;
			// 
			// custoLabel
			// 
			this.custoLabel.AutoSize = true;
			this.custoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.custoLabel.Location = new System.Drawing.Point(219, 95);
			this.custoLabel.Name = "custoLabel";
			this.custoLabel.Size = new System.Drawing.Size(41, 17);
			this.custoLabel.TabIndex = 13;
			this.custoLabel.Text = "Custo";
			// 
			// valorLabel
			// 
			this.valorLabel.AutoSize = true;
			this.valorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.valorLabel.Location = new System.Drawing.Point(13, 95);
			this.valorLabel.Name = "valorLabel";
			this.valorLabel.Size = new System.Drawing.Size(38, 17);
			this.valorLabel.TabIndex = 12;
			this.valorLabel.Text = "Valor";
			// 
			// marcaLabel
			// 
			this.marcaLabel.AutoSize = true;
			this.marcaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.marcaLabel.Location = new System.Drawing.Point(13, 57);
			this.marcaLabel.Name = "marcaLabel";
			this.marcaLabel.Size = new System.Drawing.Size(45, 17);
			this.marcaLabel.TabIndex = 11;
			this.marcaLabel.Text = "Marca";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nameLabel.Location = new System.Drawing.Point(13, 22);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(44, 17);
			this.nameLabel.TabIndex = 10;
			this.nameLabel.Text = "Nome";
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(12, 146);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(90, 28);
			this.cancelButton.TabIndex = 24;
			this.cancelButton.Text = "CANCELAR";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(332, 146);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(90, 28);
			this.saveButton.TabIndex = 25;
			this.saveButton.Text = "SALVAR";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// JanelaInfoItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 186);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.custoLine);
			this.Controls.Add(this.valorLine);
			this.Controls.Add(this.quantLine);
			this.Controls.Add(this.quantLabel);
			this.Controls.Add(this.marcaLine);
			this.Controls.Add(this.nomeLine);
			this.Controls.Add(this.custoLabel);
			this.Controls.Add(this.valorLabel);
			this.Controls.Add(this.marcaLabel);
			this.Controls.Add(this.nameLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(450, 225);
			this.MinimumSize = new System.Drawing.Size(450, 225);
			this.Name = "JanelaInfoItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alteração de Produto";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox custoLine;
		private System.Windows.Forms.TextBox valorLine;
		private System.Windows.Forms.TextBox quantLine;
		private System.Windows.Forms.Label quantLabel;
		private System.Windows.Forms.TextBox marcaLine;
		private System.Windows.Forms.TextBox nomeLine;
		private System.Windows.Forms.Label custoLabel;
		private System.Windows.Forms.Label valorLabel;
		private System.Windows.Forms.Label marcaLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
	}
}