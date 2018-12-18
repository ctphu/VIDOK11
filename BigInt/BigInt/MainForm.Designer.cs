/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 18/12/2018
 * Time: 8:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BigInt
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
			this.tbA = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbMinus = new System.Windows.Forms.RadioButton();
			this.rbPlus = new System.Windows.Forms.RadioButton();
			this.tbB = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbC = new System.Windows.Forms.TextBox();
			this.btCalc = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbA
			// 
			this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbA.Location = new System.Drawing.Point(79, 45);
			this.tbA.Name = "tbA";
			this.tbA.Size = new System.Drawing.Size(273, 30);
			this.tbA.TabIndex = 0;
			this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbMinus);
			this.groupBox1.Controls.Add(this.rbPlus);
			this.groupBox1.Location = new System.Drawing.Point(12, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(61, 82);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// rbMinus
			// 
			this.rbMinus.Location = new System.Drawing.Point(10, 51);
			this.rbMinus.Name = "rbMinus";
			this.rbMinus.Size = new System.Drawing.Size(32, 24);
			this.rbMinus.TabIndex = 1;
			this.rbMinus.Text = "-";
			this.rbMinus.UseVisualStyleBackColor = true;
			// 
			// rbPlus
			// 
			this.rbPlus.Checked = true;
			this.rbPlus.Location = new System.Drawing.Point(10, 21);
			this.rbPlus.Name = "rbPlus";
			this.rbPlus.Size = new System.Drawing.Size(32, 24);
			this.rbPlus.TabIndex = 0;
			this.rbPlus.TabStop = true;
			this.rbPlus.Text = "+";
			this.rbPlus.UseVisualStyleBackColor = true;
			// 
			// tbB
			// 
			this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbB.Location = new System.Drawing.Point(79, 81);
			this.tbB.Name = "tbB";
			this.tbB.Size = new System.Drawing.Size(273, 30);
			this.tbB.TabIndex = 2;
			this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(79, 116);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(273, 2);
			this.panel1.TabIndex = 3;
			// 
			// tbC
			// 
			this.tbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbC.Location = new System.Drawing.Point(79, 124);
			this.tbC.Name = "tbC";
			this.tbC.Size = new System.Drawing.Size(273, 30);
			this.tbC.TabIndex = 4;
			this.tbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btCalc
			// 
			this.btCalc.Location = new System.Drawing.Point(404, 45);
			this.btCalc.Name = "btCalc";
			this.btCalc.Size = new System.Drawing.Size(114, 30);
			this.btCalc.TabIndex = 5;
			this.btCalc.Text = "Calc";
			this.btCalc.UseVisualStyleBackColor = true;
			this.btCalc.Click += new System.EventHandler(this.BtCalcClick);
			// 
			// btClose
			// 
			this.btClose.Location = new System.Drawing.Point(404, 116);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(114, 30);
			this.btClose.TabIndex = 6;
			this.btClose.Text = "Close";
			this.btClose.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 195);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btCalc);
			this.Controls.Add(this.tbC);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tbB);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbA);
			this.Name = "MainForm";
			this.Text = "BigInt";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btCalc;
		private System.Windows.Forms.TextBox tbC;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbB;
		private System.Windows.Forms.RadioButton rbPlus;
		private System.Windows.Forms.RadioButton rbMinus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbA;
	}
}
