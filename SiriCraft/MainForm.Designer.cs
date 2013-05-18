/*
 * Created by SharpDevelop.
 * User: Sirikon
 * Date: 17/04/2013
 * Time: 22:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SiriCraft
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.userName = new System.Windows.Forms.TextBox();
			this.EnterButton = new System.Windows.Forms.Button();
			this.showConsole = new System.Windows.Forms.CheckBox();
			this.megabytes = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.megabytes)).BeginInit();
			this.SuspendLayout();
			// 
			// userName
			// 
			this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userName.Location = new System.Drawing.Point(12, 12);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(290, 26);
			this.userName.TabIndex = 0;
			// 
			// EnterButton
			// 
			this.EnterButton.Location = new System.Drawing.Point(308, 12);
			this.EnterButton.Name = "EnterButton";
			this.EnterButton.Size = new System.Drawing.Size(75, 26);
			this.EnterButton.TabIndex = 1;
			this.EnterButton.Text = "Entrar";
			this.EnterButton.UseVisualStyleBackColor = true;
			this.EnterButton.Click += new System.EventHandler(this.EnterButtonClick);
			// 
			// showConsole
			// 
			this.showConsole.Location = new System.Drawing.Point(12, 41);
			this.showConsole.Name = "showConsole";
			this.showConsole.Size = new System.Drawing.Size(104, 24);
			this.showConsole.TabIndex = 2;
			this.showConsole.Text = "Show Console";
			this.showConsole.UseVisualStyleBackColor = true;
			// 
			// megabytes
			// 
			this.megabytes.Location = new System.Drawing.Point(263, 44);
			this.megabytes.Maximum = new decimal(new int[] {
									8192,
									0,
									0,
									0});
			this.megabytes.Minimum = new decimal(new int[] {
									512,
									0,
									0,
									0});
			this.megabytes.Name = "megabytes";
			this.megabytes.Size = new System.Drawing.Size(120, 20);
			this.megabytes.TabIndex = 3;
			this.megabytes.Value = new decimal(new int[] {
									512,
									0,
									0,
									0});
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 75);
			this.Controls.Add(this.megabytes);
			this.Controls.Add(this.showConsole);
			this.Controls.Add(this.EnterButton);
			this.Controls.Add(this.userName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(411, 114);
			this.MinimumSize = new System.Drawing.Size(411, 114);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SiriCraft";
			((System.ComponentModel.ISupportInitialize)(this.megabytes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown megabytes;
		private System.Windows.Forms.CheckBox showConsole;
		private System.Windows.Forms.Button EnterButton;
		private System.Windows.Forms.TextBox userName;
	}
}
