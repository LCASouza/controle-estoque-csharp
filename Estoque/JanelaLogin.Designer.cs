
namespace Estoque
{
	partial class JanelaLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaLogin));
			this.userLine = new System.Windows.Forms.TextBox();
			this.userLabel = new System.Windows.Forms.Label();
			this.passwdLine = new System.Windows.Forms.TextBox();
			this.passwdLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.quitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userLine
			// 
			this.userLine.Location = new System.Drawing.Point(35, 41);
			this.userLine.MaxLength = 25;
			this.userLine.Name = "userLine";
			this.userLine.Size = new System.Drawing.Size(283, 23);
			this.userLine.TabIndex = 0;
			this.userLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Location = new System.Drawing.Point(152, 23);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(47, 15);
			this.userLabel.TabIndex = 1;
			this.userLabel.Text = "Usuário";
			// 
			// passwdLine
			// 
			this.passwdLine.Location = new System.Drawing.Point(35, 96);
			this.passwdLine.MaxLength = 25;
			this.passwdLine.Name = "passwdLine";
			this.passwdLine.Size = new System.Drawing.Size(283, 23);
			this.passwdLine.TabIndex = 2;
			this.passwdLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.passwdLine.UseSystemPasswordChar = true;
			// 
			// passwdLabel
			// 
			this.passwdLabel.AutoSize = true;
			this.passwdLabel.Location = new System.Drawing.Point(156, 78);
			this.passwdLabel.Name = "passwdLabel";
			this.passwdLabel.Size = new System.Drawing.Size(39, 15);
			this.passwdLabel.TabIndex = 3;
			this.passwdLabel.Text = "Senha";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(147, 187);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(59, 15);
			this.versionLabel.TabIndex = 4;
			this.versionLabel.Text = "versão 1.0";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(203, 136);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 25);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "LOGIN";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// quitButton
			// 
			this.quitButton.Location = new System.Drawing.Point(74, 136);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(75, 25);
			this.quitButton.TabIndex = 6;
			this.quitButton.Text = "SAIR";
			this.quitButton.UseVisualStyleBackColor = true;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// JanelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 211);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.passwdLabel);
			this.Controls.Add(this.passwdLine);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.userLine);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(370, 250);
			this.MinimumSize = new System.Drawing.Size(370, 250);
			this.Name = "JanelaLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Estoque";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox userLine;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.TextBox passwdLine;
		private System.Windows.Forms.Label passwdLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button quitButton;
	}
}