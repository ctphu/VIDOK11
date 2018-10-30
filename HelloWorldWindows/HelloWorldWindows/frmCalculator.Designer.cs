/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 30/10/2018
 * Time: 9:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HelloWorldWindows
{
	partial class frmCalculator
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
			this.tbDisplay = new System.Windows.Forms.TextBox();
			this.bt00 = new System.Windows.Forms.Button();
			this.bt0 = new System.Windows.Forms.Button();
			this.btDot = new System.Windows.Forms.Button();
			this.btEqual = new System.Windows.Forms.Button();
			this.bt1 = new System.Windows.Forms.Button();
			this.bt2 = new System.Windows.Forms.Button();
			this.bt3 = new System.Windows.Forms.Button();
			this.btDiv = new System.Windows.Forms.Button();
			this.bt4 = new System.Windows.Forms.Button();
			this.bt5 = new System.Windows.Forms.Button();
			this.bt6 = new System.Windows.Forms.Button();
			this.btMulti = new System.Windows.Forms.Button();
			this.bt7 = new System.Windows.Forms.Button();
			this.bt8 = new System.Windows.Forms.Button();
			this.bt9 = new System.Windows.Forms.Button();
			this.btMinus = new System.Windows.Forms.Button();
			this.btC = new System.Windows.Forms.Button();
			this.btMR = new System.Windows.Forms.Button();
			this.btMPlus = new System.Windows.Forms.Button();
			this.btPlus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbDisplay
			// 
			this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDisplay.Location = new System.Drawing.Point(23, 22);
			this.tbDisplay.Name = "tbDisplay";
			this.tbDisplay.ReadOnly = true;
			this.tbDisplay.Size = new System.Drawing.Size(330, 30);
			this.tbDisplay.TabIndex = 0;
			this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// bt00
			// 
			this.bt00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt00.Location = new System.Drawing.Point(23, 310);
			this.bt00.Name = "bt00";
			this.bt00.Size = new System.Drawing.Size(78, 53);
			this.bt00.TabIndex = 1;
			this.bt00.Text = "000";
			this.bt00.UseVisualStyleBackColor = true;
			this.bt00.Click += new System.EventHandler(this.Bt00Click);
			// 
			// bt0
			// 
			this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt0.Location = new System.Drawing.Point(107, 310);
			this.bt0.Name = "bt0";
			this.bt0.Size = new System.Drawing.Size(78, 53);
			this.bt0.TabIndex = 1;
			this.bt0.Text = "0";
			this.bt0.UseVisualStyleBackColor = true;
			this.bt0.Click += new System.EventHandler(this.Bt0Click);
			// 
			// btDot
			// 
			this.btDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDot.Location = new System.Drawing.Point(191, 310);
			this.btDot.Name = "btDot";
			this.btDot.Size = new System.Drawing.Size(78, 53);
			this.btDot.TabIndex = 1;
			this.btDot.Text = ".";
			this.btDot.UseVisualStyleBackColor = true;
			this.btDot.Click += new System.EventHandler(this.BtDotClick);
			// 
			// btEqual
			// 
			this.btEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btEqual.Location = new System.Drawing.Point(275, 310);
			this.btEqual.Name = "btEqual";
			this.btEqual.Size = new System.Drawing.Size(78, 53);
			this.btEqual.TabIndex = 1;
			this.btEqual.Text = "=";
			this.btEqual.UseVisualStyleBackColor = true;
			this.btEqual.Click += new System.EventHandler(this.BtEqualClick);
			// 
			// bt1
			// 
			this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt1.Location = new System.Drawing.Point(23, 251);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(78, 53);
			this.bt1.TabIndex = 1;
			this.bt1.Text = "1";
			this.bt1.UseVisualStyleBackColor = true;
			this.bt1.Click += new System.EventHandler(this.Bt1Click);
			// 
			// bt2
			// 
			this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt2.Location = new System.Drawing.Point(107, 251);
			this.bt2.Name = "bt2";
			this.bt2.Size = new System.Drawing.Size(78, 53);
			this.bt2.TabIndex = 1;
			this.bt2.Text = "2";
			this.bt2.UseVisualStyleBackColor = true;
			this.bt2.Click += new System.EventHandler(this.Bt2Click);
			// 
			// bt3
			// 
			this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt3.Location = new System.Drawing.Point(191, 251);
			this.bt3.Name = "bt3";
			this.bt3.Size = new System.Drawing.Size(78, 53);
			this.bt3.TabIndex = 1;
			this.bt3.Text = "3";
			this.bt3.UseVisualStyleBackColor = true;
			this.bt3.Click += new System.EventHandler(this.Bt3Click);
			// 
			// btDiv
			// 
			this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDiv.Location = new System.Drawing.Point(275, 251);
			this.btDiv.Name = "btDiv";
			this.btDiv.Size = new System.Drawing.Size(78, 53);
			this.btDiv.TabIndex = 1;
			this.btDiv.Text = "/";
			this.btDiv.UseVisualStyleBackColor = true;
			// 
			// bt4
			// 
			this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt4.Location = new System.Drawing.Point(23, 192);
			this.bt4.Name = "bt4";
			this.bt4.Size = new System.Drawing.Size(78, 53);
			this.bt4.TabIndex = 1;
			this.bt4.Text = "4";
			this.bt4.UseVisualStyleBackColor = true;
			this.bt4.Click += new System.EventHandler(this.Bt4Click);
			// 
			// bt5
			// 
			this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt5.Location = new System.Drawing.Point(107, 192);
			this.bt5.Name = "bt5";
			this.bt5.Size = new System.Drawing.Size(78, 53);
			this.bt5.TabIndex = 1;
			this.bt5.Text = "5";
			this.bt5.UseVisualStyleBackColor = true;
			this.bt5.Click += new System.EventHandler(this.Bt5Click);
			// 
			// bt6
			// 
			this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt6.Location = new System.Drawing.Point(191, 192);
			this.bt6.Name = "bt6";
			this.bt6.Size = new System.Drawing.Size(78, 53);
			this.bt6.TabIndex = 1;
			this.bt6.Text = "6";
			this.bt6.UseVisualStyleBackColor = true;
			this.bt6.Click += new System.EventHandler(this.Bt6Click);
			// 
			// btMulti
			// 
			this.btMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMulti.Location = new System.Drawing.Point(275, 192);
			this.btMulti.Name = "btMulti";
			this.btMulti.Size = new System.Drawing.Size(78, 53);
			this.btMulti.TabIndex = 1;
			this.btMulti.Text = "*";
			this.btMulti.UseVisualStyleBackColor = true;
			// 
			// bt7
			// 
			this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt7.Location = new System.Drawing.Point(23, 133);
			this.bt7.Name = "bt7";
			this.bt7.Size = new System.Drawing.Size(78, 53);
			this.bt7.TabIndex = 1;
			this.bt7.Text = "7";
			this.bt7.UseVisualStyleBackColor = true;
			this.bt7.Click += new System.EventHandler(this.Bt7Click);
			// 
			// bt8
			// 
			this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt8.Location = new System.Drawing.Point(107, 133);
			this.bt8.Name = "bt8";
			this.bt8.Size = new System.Drawing.Size(78, 53);
			this.bt8.TabIndex = 1;
			this.bt8.Text = "8";
			this.bt8.UseVisualStyleBackColor = true;
			this.bt8.Click += new System.EventHandler(this.Bt8Click);
			// 
			// bt9
			// 
			this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt9.Location = new System.Drawing.Point(191, 133);
			this.bt9.Name = "bt9";
			this.bt9.Size = new System.Drawing.Size(78, 53);
			this.bt9.TabIndex = 1;
			this.bt9.Text = "9";
			this.bt9.UseVisualStyleBackColor = true;
			this.bt9.Click += new System.EventHandler(this.Bt9Click);
			// 
			// btMinus
			// 
			this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMinus.Location = new System.Drawing.Point(275, 133);
			this.btMinus.Name = "btMinus";
			this.btMinus.Size = new System.Drawing.Size(78, 53);
			this.btMinus.TabIndex = 1;
			this.btMinus.Text = "-";
			this.btMinus.UseVisualStyleBackColor = true;
			// 
			// btC
			// 
			this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btC.Location = new System.Drawing.Point(23, 74);
			this.btC.Name = "btC";
			this.btC.Size = new System.Drawing.Size(78, 53);
			this.btC.TabIndex = 1;
			this.btC.Text = "C";
			this.btC.UseVisualStyleBackColor = true;
			this.btC.Click += new System.EventHandler(this.BtCClick);
			// 
			// btMR
			// 
			this.btMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMR.Location = new System.Drawing.Point(107, 74);
			this.btMR.Name = "btMR";
			this.btMR.Size = new System.Drawing.Size(78, 53);
			this.btMR.TabIndex = 1;
			this.btMR.Text = "MR";
			this.btMR.UseVisualStyleBackColor = true;
			// 
			// btMPlus
			// 
			this.btMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMPlus.Location = new System.Drawing.Point(191, 74);
			this.btMPlus.Name = "btMPlus";
			this.btMPlus.Size = new System.Drawing.Size(78, 53);
			this.btMPlus.TabIndex = 1;
			this.btMPlus.Text = "M+";
			this.btMPlus.UseVisualStyleBackColor = true;
			// 
			// btPlus
			// 
			this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btPlus.Location = new System.Drawing.Point(275, 74);
			this.btPlus.Name = "btPlus";
			this.btPlus.Size = new System.Drawing.Size(78, 53);
			this.btPlus.TabIndex = 1;
			this.btPlus.Text = "+";
			this.btPlus.UseVisualStyleBackColor = true;
			this.btPlus.Click += new System.EventHandler(this.BtPlusClick);
			// 
			// frmCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 389);
			this.Controls.Add(this.btPlus);
			this.Controls.Add(this.btMinus);
			this.Controls.Add(this.btMPlus);
			this.Controls.Add(this.btMulti);
			this.Controls.Add(this.bt9);
			this.Controls.Add(this.bt6);
			this.Controls.Add(this.btDiv);
			this.Controls.Add(this.btMR);
			this.Controls.Add(this.bt3);
			this.Controls.Add(this.bt8);
			this.Controls.Add(this.bt5);
			this.Controls.Add(this.btEqual);
			this.Controls.Add(this.btC);
			this.Controls.Add(this.bt2);
			this.Controls.Add(this.bt7);
			this.Controls.Add(this.bt4);
			this.Controls.Add(this.btDot);
			this.Controls.Add(this.bt1);
			this.Controls.Add(this.bt0);
			this.Controls.Add(this.bt00);
			this.Controls.Add(this.tbDisplay);
			this.Name = "frmCalculator";
			this.Text = "frmCalculator";
			this.Load += new System.EventHandler(this.FrmCalculatorLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btPlus;
		private System.Windows.Forms.Button btMPlus;
		private System.Windows.Forms.Button btMR;
		private System.Windows.Forms.Button btC;
		private System.Windows.Forms.Button btMinus;
		private System.Windows.Forms.Button bt9;
		private System.Windows.Forms.Button bt8;
		private System.Windows.Forms.Button bt7;
		private System.Windows.Forms.Button btMulti;
		private System.Windows.Forms.Button bt6;
		private System.Windows.Forms.Button bt5;
		private System.Windows.Forms.Button bt4;
		private System.Windows.Forms.Button btDiv;
		private System.Windows.Forms.Button bt3;
		private System.Windows.Forms.Button bt2;
		private System.Windows.Forms.Button bt1;
		private System.Windows.Forms.Button btEqual;
		private System.Windows.Forms.Button btDot;
		private System.Windows.Forms.Button bt0;
		private System.Windows.Forms.Button bt00;
		private System.Windows.Forms.TextBox tbDisplay;
	}
}
