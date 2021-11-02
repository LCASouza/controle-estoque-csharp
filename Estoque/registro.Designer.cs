
namespace Estoque
{
	partial class registro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
			this.quantLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.quantLine = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// quantLabel
			// 
			this.quantLabel.AutoSize = true;
			this.quantLabel.Location = new System.Drawing.Point(113, 24);
			this.quantLabel.Name = "quantLabel";
			this.quantLabel.Size = new System.Drawing.Size(69, 15);
			this.quantLabel.TabIndex = 0;
			this.quantLabel.Text = "Quantidade";
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(12, 88);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(79, 26);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "CANCELAR";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// quantLine
			// 
			this.quantLine.Location = new System.Drawing.Point(97, 42);
			this.quantLine.MaxLength = 6;
			this.quantLine.Name = "quantLine";
			this.quantLine.Size = new System.Drawing.Size(100, 23);
			this.quantLine.TabIndex = 3;
			this.quantLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.quantLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantKeyLine);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(202, 88);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(79, 26);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "SALVAR";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 126);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.quantLine);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.quantLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(310, 165);
			this.MinimumSize = new System.Drawing.Size(310, 165);
			this.Name = "registro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Registro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label quantLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TextBox quantLine;
		private System.Windows.Forms.Button saveButton;
	}
}