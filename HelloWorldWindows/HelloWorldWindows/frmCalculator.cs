/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 30/10/2018
 * Time: 9:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelloWorldWindows
{
	/// <summary>
	/// Description of frmCalculator.
	/// </summary>
	public partial class frmCalculator : Form
	{
		bool bIsNewNumber = true, bIsInputValue1 = true;
		double dValue1, dValue2, dResult;
		int iOperator;
		public frmCalculator()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmCalculatorLoad(object sender, EventArgs e)
		{
			
		}
		
		void Bt00Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "000";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "000";
			}
		}
		
		void Bt0Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "0";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "0";
			}
		}
		
		void Bt1Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "1";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "1";
			}
		}
		
		void Bt2Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "2";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "2";
			}
		}
		
		void Bt3Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "3";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "3";
			}
		}
		
		void Bt4Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "4";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "4";
			}
		}
		
		void Bt5Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "5";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "5";
			}
		}
		
		void Bt6Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "6";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "6";
			}
		}
		
		void Bt7Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "7";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "7";
			}
		}
		
		void Bt8Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "8";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "8";
			}
		}
		
		void Bt9Click(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = "9";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + "9";
			}
		}
		
		void BtCClick(object sender, EventArgs e)
		{
			tbDisplay.Text = "";
			bIsNewNumber = true;
			bIsInputValue1 = true;
		}
		
		void BtDotClick(object sender, EventArgs e)
		{
			if(bIsNewNumber == true)
			{
				tbDisplay.Text = ".";
				bIsNewNumber = false;
			}
			else
			{
				tbDisplay.Text = tbDisplay.Text + ".";
			}
		}
		
		void BtPlusClick(object sender, EventArgs e)
		{
			try
			{
				if (bIsInputValue1 == true)
				{
					dValue1 = double.Parse(tbDisplay.Text);	
					bIsNewNumber = true;
					bIsInputValue1 = false;
				}
				else
				{
					dValue2 = double.Parse(tbDisplay.Text);
					//dResult = dValue1 + dValue2;
					tbDisplay.Text = dResult.ToString();
					dValue1 = dResult;
					bIsNewNumber = true;
				}
				//
				iOperator = 0;//Plus
			}
			catch
			{
				tbDisplay.Text="";
			}
		}
		
		void BtEqualClick(object sender, EventArgs e)
		{
			try 
			{
				if (bIsInputValue1 == false)
				{
					dValue2 = double.Parse(tbDisplay.Text);
					if(iOperator == 0)
					{
						dResult = dValue1 + dValue2;
						tbDisplay.Text = dResult.ToString();
						dValue1 = dResult;
						bIsNewNumber = true;
					}
					
				}
				
				
			} catch  
			{
				
				
			}
		}
	}
}
