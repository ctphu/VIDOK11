/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/6/2018
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace OOP_onequarter
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
			this.txtTop1 = new System.Windows.Forms.TextBox();
			this.txtBottom2 = new System.Windows.Forms.TextBox();
			this.txtBottom3 = new System.Windows.Forms.TextBox();
			this.txtTop3 = new System.Windows.Forms.TextBox();
			this.txtTop2 = new System.Windows.Forms.TextBox();
			this.txtBottom1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbDivi = new System.Windows.Forms.RadioButton();
			this.rdbMult = new System.Windows.Forms.RadioButton();
			this.rdbSub = new System.Windows.Forms.RadioButton();
			this.rdbPlus = new System.Windows.Forms.RadioButton();
			this.btnEqual = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTop1
			// 
			this.txtTop1.Location = new System.Drawing.Point(48, 69);
			this.txtTop1.Margin = new System.Windows.Forms.Padding(4);
			this.txtTop1.Name = "txtTop1";
			this.txtTop1.Size = new System.Drawing.Size(78, 22);
			this.txtTop1.TabIndex = 0;
			this.txtTop1.TextChanged += new System.EventHandler(this.TxtTop1TextChanged);
			// 
			// txtBottom2
			// 
			this.txtBottom2.Location = new System.Drawing.Point(255, 109);
			this.txtBottom2.Margin = new System.Windows.Forms.Padding(4);
			this.txtBottom2.Name = "txtBottom2";
			this.txtBottom2.Size = new System.Drawing.Size(74, 22);
			this.txtBottom2.TabIndex = 4;
			this.txtBottom2.TextChanged += new System.EventHandler(this.TxtBottom2TextChanged);
			// 
			// txtBottom3
			// 
			this.txtBottom3.Location = new System.Drawing.Point(441, 109);
			this.txtBottom3.Margin = new System.Windows.Forms.Padding(4);
			this.txtBottom3.Name = "txtBottom3";
			this.txtBottom3.Size = new System.Drawing.Size(73, 22);
			this.txtBottom3.TabIndex = 8;
			// 
			// txtTop3
			// 
			this.txtTop3.Location = new System.Drawing.Point(441, 70);
			this.txtTop3.Margin = new System.Windows.Forms.Padding(4);
			this.txtTop3.Name = "txtTop3";
			this.txtTop3.Size = new System.Drawing.Size(73, 22);
			this.txtTop3.TabIndex = 7;
			// 
			// txtTop2
			// 
			this.txtTop2.Location = new System.Drawing.Point(255, 69);
			this.txtTop2.Margin = new System.Windows.Forms.Padding(4);
			this.txtTop2.Name = "txtTop2";
			this.txtTop2.Size = new System.Drawing.Size(74, 22);
			this.txtTop2.TabIndex = 2;
			this.txtTop2.TextChanged += new System.EventHandler(this.TxtTop2TextChanged);
			// 
			// txtBottom1
			// 
			this.txtBottom1.Location = new System.Drawing.Point(48, 109);
			this.txtBottom1.Margin = new System.Windows.Forms.Padding(4);
			this.txtBottom1.Name = "txtBottom1";
			this.txtBottom1.Size = new System.Drawing.Size(78, 22);
			this.txtBottom1.TabIndex = 1;
			this.txtBottom1.TextChanged += new System.EventHandler(this.TxtBottom1TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 95);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 10);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(441, 96);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 10);
			this.label2.TabIndex = 7;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(255, 95);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 10);
			this.label3.TabIndex = 3;
			this.label3.Text = "label3";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbDivi);
			this.groupBox1.Controls.Add(this.rdbMult);
			this.groupBox1.Controls.Add(this.rdbSub);
			this.groupBox1.Controls.Add(this.rdbPlus);
			this.groupBox1.Location = new System.Drawing.Point(134, 54);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(113, 77);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// rdbDivi
			// 
			this.rdbDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbDivi.Location = new System.Drawing.Point(57, 47);
			this.rdbDivi.Margin = new System.Windows.Forms.Padding(4);
			this.rdbDivi.Name = "rdbDivi";
			this.rdbDivi.Size = new System.Drawing.Size(42, 22);
			this.rdbDivi.TabIndex = 3;
			this.rdbDivi.Text = "/";
			this.rdbDivi.UseVisualStyleBackColor = true;
			// 
			// rdbMult
			// 
			this.rdbMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbMult.Location = new System.Drawing.Point(58, 16);
			this.rdbMult.Margin = new System.Windows.Forms.Padding(4);
			this.rdbMult.Name = "rdbMult";
			this.rdbMult.Size = new System.Drawing.Size(41, 23);
			this.rdbMult.TabIndex = 2;
			this.rdbMult.Text = "*";
			this.rdbMult.UseVisualStyleBackColor = true;
			// 
			// rdbSub
			// 
			this.rdbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbSub.Location = new System.Drawing.Point(7, 41);
			this.rdbSub.Margin = new System.Windows.Forms.Padding(4);
			this.rdbSub.Name = "rdbSub";
			this.rdbSub.Size = new System.Drawing.Size(42, 28);
			this.rdbSub.TabIndex = 1;
			this.rdbSub.Text = "-";
			this.rdbSub.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.rdbSub.UseVisualStyleBackColor = true;
			// 
			// rdbPlus
			// 
			this.rdbPlus.Checked = true;
			this.rdbPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbPlus.Location = new System.Drawing.Point(8, 14);
			this.rdbPlus.Margin = new System.Windows.Forms.Padding(4);
			this.rdbPlus.Name = "rdbPlus";
			this.rdbPlus.Size = new System.Drawing.Size(42, 25);
			this.rdbPlus.TabIndex = 1;
			this.rdbPlus.TabStop = true;
			this.rdbPlus.Text = "+";
			this.rdbPlus.UseVisualStyleBackColor = true;
			this.rdbPlus.CheckedChanged += new System.EventHandler(this.RdbPlusCheckedChanged);
			// 
			// btnEqual
			// 
			this.btnEqual.Location = new System.Drawing.Point(350, 70);
			this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(66, 61);
			this.btnEqual.TabIndex = 6;
			this.btnEqual.Text = "=";
			this.btnEqual.UseVisualStyleBackColor = true;
			this.btnEqual.Click += new System.EventHandler(this.BtnEqualClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MediumBlue;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(45, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(468, 34);
			this.label4.TabIndex = 10;
			this.label4.Text = "Caculator";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(537, 146);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnEqual);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBottom1);
			this.Controls.Add(this.txtTop2);
			this.Controls.Add(this.txtTop3);
			this.Controls.Add(this.txtBottom3);
			this.Controls.Add(this.txtBottom2);
			this.Controls.Add(this.txtTop1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "OOP_onequarter";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnEqual;
		private System.Windows.Forms.RadioButton rdbPlus;
		private System.Windows.Forms.RadioButton rdbSub;
		private System.Windows.Forms.RadioButton rdbMult;
		private System.Windows.Forms.RadioButton rdbDivi;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBottom1;
		private System.Windows.Forms.TextBox txtTop2;
		private System.Windows.Forms.TextBox txtTop3;
		private System.Windows.Forms.TextBox txtBottom3;
		private System.Windows.Forms.TextBox txtBottom2;
		private System.Windows.Forms.TextBox txtTop1;
	}
}
