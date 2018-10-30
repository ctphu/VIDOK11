/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 30/10/2018
 * Time: 8:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HelloWorldWindows
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btnHello = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Your Name:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(174, 25);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(185, 22);
			this.tbName.TabIndex = 1;
			// 
			// btnHello
			// 
			this.btnHello.Location = new System.Drawing.Point(135, 77);
			this.btnHello.Name = "btnHello";
			this.btnHello.Size = new System.Drawing.Size(122, 32);
			this.btnHello.TabIndex = 2;
			this.btnHello.Text = "Hello";
			this.btnHello.UseVisualStyleBackColor = true;
			this.btnHello.Click += new System.EventHandler(this.BtnHelloClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnHello;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 143);
			this.Controls.Add(this.btnHello);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "HelloWorldWindows";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnHello;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
	}
}
