/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 30/10/2018
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelloWorldWindows
{
	/// <summary>
	/// Description of frmLogin.
	/// </summary>
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			if(tbUserName.Text == "admin1" && tbPassword.Text=="password1")
			{
				this.Hide();
				frmCalculator fCal = new frmCalculator();
				fCal.ShowDialog();
				//MessageBox.Show("Hello User: "+tbUserName.Text);
				this.Close();
			}
			else
			{
				MessageBox.Show("Invalid UserName or Password !", "Error", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Stop);
			}
		}
	}
}
