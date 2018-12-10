/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/6/2018
 * Time: 8:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_onequarter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		fraction fra = new fraction();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		public void ClearData()
		{
			this.txtBottom1.Text = "";
			this.txtBottom2.Text = "";
			this.txtBottom3.Text = "";
			this.txtTop1.Text = "";
			this.txtTop3.Text = "";
			this.txtTop2.Text = "";
		}
		
		
		void TxtTop1TextChanged(object sender, EventArgs e)
		{
			int ntop1;
			try
			{
				ntop1 = int.Parse(txtTop1.Text);
				
			}catch
			{
				txtTop1.Text = "";
			}
		}
		
		void TxtTop2TextChanged(object sender, EventArgs e)
		{
			int ntop2;
			try
			{
				ntop2 = int.Parse(txtTop2.Text);
				
			}catch
			{
				txtTop2.Text = "";
			}
		}
		
		void TxtBottom1TextChanged(object sender, EventArgs e)
		{
			int nbottom1;
			try
			{
				nbottom1 = int.Parse(txtBottom1.Text);
				if (nbottom1 == 0)
					
				{
					MessageBox.Show(" | Please check|", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtBottom1.Text ="";
				}
			}catch
			{
				txtBottom1.Text  = "";
			}
		}
		
		void TxtBottom2TextChanged(object sender, EventArgs e)
		{
			int nbottom2;
			try
			{
				nbottom2 = int.Parse(txtBottom2.Text);
				if (nbottom2 == 0)
					
				{
					MessageBox.Show(" | Please check|", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtBottom2.Text ="";
				}
			}catch
			{
				txtBottom2.Text  = "";
			}
		}
		
		void RdbPlusCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnEqualClick(object sender, EventArgs e)
		{
			fraction a = new fraction();
			fraction b = new fraction();
			fraction c = new fraction();
			if (rdbPlus.Checked == true)
			{
				a.top = int.Parse(txtTop1.Text);
				a.bottom = int.Parse(txtBottom1.Text);
				b.top = int.Parse(txtTop2.Text);
				b.bottom = int.Parse(txtBottom2.Text);
				c = fraction.Plus(a, b);
				txtTop3.Text = c.top.ToString();
				txtBottom3.Text = c.bottom.ToString();
				
			}
			else
			{
				c = new fraction();
			}
			
			//=========================
			if (rdbSub.Checked == true)
			{
				a.top = int.Parse(txtTop1.Text);
				a.bottom = int.Parse(txtBottom1.Text);
				b.top = int.Parse(txtTop2.Text);
				b.bottom = int.Parse(txtBottom2.Text);
				c = fraction.Subtract(a, b);
				txtTop3.Text = c.top.ToString();
				txtBottom3.Text = c.bottom.ToString();
				
			}
			else
			{
				c = new fraction();
			}
			//========================
			if (rdbMult.Checked == true)
			{
				a.top = int.Parse(txtTop1.Text);
				a.bottom = int.Parse(txtBottom1.Text);
				b.top = int.Parse(txtTop2.Text);
				b.bottom = int.Parse(txtBottom2.Text);
				c = fraction.Multilpe(a, b);
				txtTop3.Text = c.top.ToString();
				txtBottom3.Text = c.bottom.ToString();
				
			}
			else
			{
				c = new fraction();
			}
			if (rdbDivi.Checked == true)
			{
				a.top = int.Parse(txtTop1.Text);
				a.bottom = int.Parse(txtBottom1.Text);
				b.top = int.Parse(txtTop2.Text);
				b.bottom = int.Parse(txtBottom2.Text);
				if(b.top != 0 && b.bottom != 0)
				{
					c = fraction.Div(a, b);
					txtTop3.Text = c.top.ToString();
					txtBottom3.Text = c.bottom.ToString();
				}
				else
				{
					MessageBox.Show(" | Please check|", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				c = new fraction();
			}
		}
	}
}
