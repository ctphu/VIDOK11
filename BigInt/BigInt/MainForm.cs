/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 18/12/2018
 * Time: 8:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BigInt
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		BigInt a, b, c;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			a = new BigInt();
			b = new BigInt();
			c = new BigInt();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtCalcClick(object sender, EventArgs e)
		{
			a.Value = tbA.Text;
			b.Value = tbB.Text;
			if(rbPlus.Checked == true)
				c = a + b;
			else
				c = a - b;
			
			tbC.Text = c.Value;
//			if(a>b)
//				tbC.Text = "A>B";
//			else if (a == b)
//				tbC.Text = "A=B";
//			else
//				tbC.Text = "A<B";
				
			//c.Value = tbC.Text;
		}
	}
}
