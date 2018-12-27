/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 27/12/2018
 * Time: 8:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VIDOPaint
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbLine = new System.Windows.Forms.ToolStripButton();
			this.tsbRectangle = new System.Windows.Forms.ToolStripButton();
			this.tsbCircle = new System.Windows.Forms.ToolStripButton();
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbLine,
									this.tsbRectangle,
									this.tsbCircle});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(797, 43);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbLine
			// 
			this.tsbLine.CheckOnClick = true;
			this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
			this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new System.Drawing.Size(40, 40);
			this.tsbLine.Text = "Line";
			this.tsbLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbRectangle
			// 
			this.tsbRectangle.CheckOnClick = true;
			this.tsbRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbRectangle.Image")));
			this.tsbRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRectangle.Name = "tsbRectangle";
			this.tsbRectangle.Size = new System.Drawing.Size(79, 40);
			this.tsbRectangle.Text = "Rectangle";
			this.tsbRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbCircle
			// 
			this.tsbCircle.CheckOnClick = true;
			this.tsbCircle.Image = ((System.Drawing.Image)(resources.GetObject("tsbCircle.Image")));
			this.tsbCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCircle.Name = "tsbCircle";
			this.tsbCircle.Size = new System.Drawing.Size(50, 40);
			this.tsbCircle.Text = "Circle";
			this.tsbCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.White;
			this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraw.Location = new System.Drawing.Point(0, 43);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(797, 395);
			this.pbDraw.TabIndex = 1;
			this.pbDraw.TabStop = false;
			this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 438);
			this.Controls.Add(this.pbDraw);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "VIDOPaint";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.ToolStripButton tsbCircle;
		private System.Windows.Forms.ToolStripButton tsbRectangle;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
