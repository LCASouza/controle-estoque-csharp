
namespace Estoque
{
	partial class FirstUse
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstUse));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.userLine = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.passwdLine = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.databaseLine = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(417, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "CONECTAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "CANCELAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// userLine
			// 
			this.userLine.Location = new System.Drawing.Point(130, 55);
			this.userLine.MaxLength = 50;
			this.userLine.Name = "userLine";
			this.userLine.Size = new System.Drawing.Size(269, 23);
			this.userLine.TabIndex = 2;
			this.userLine.Text = "root";
			this.userLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(215, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuário do Banco";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(243, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Senha";
			// 
			// passwdLine
			// 
			this.passwdLine.Location = new System.Drawing.Point(130, 112);
			this.passwdLine.MaxLength = 50;
			this.passwdLine.Name = "passwdLine";
			this.passwdLine.Size = new System.Drawing.Size(269, 23);
			this.passwdLine.TabIndex = 4;
			this.passwdLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.passwdLine.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(218, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nome do Banco";
			// 
			// databaseLine
			// 
			this.databaseLine.Location = new System.Drawing.Point(130, 168);
			this.databaseLine.MaxLength = 25;
			this.databaseLine.Name = "databaseLine";
			this.databaseLine.Size = new System.Drawing.Size(269, 23);
			this.databaseLine.TabIndex = 6;
			this.databaseLine.Text = "estoque";
			this.databaseLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FirstUse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 269);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.databaseLine);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.passwdLine);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.userLine);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(545, 308);
			this.MinimumSize = new System.Drawing.Size(545, 308);
			this.Name = "FirstUse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Conectar ao Banco de Dados";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox userLine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwdLine;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox databaseLine;
	}
}