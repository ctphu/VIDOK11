/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 01/11/2018
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelloWorldWindows
{
	/// <summary>
	/// Description of frmThiSinh.
	/// </summary>
	public partial class frmThiSinh : Form
	{
		clsThiSinh thisinh = new clsThiSinh();
		
		public frmThiSinh()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void ClearData()
		{
			tbMaSo.Text = "";
			tbHoTen.Text = "";
			cbDiemToan.Text = "0";
			cbDiemLy.Text = "0";
			cbDiemHoa.Text = "0";
			tbDiemTrungBinh.Text = "0";
			tbKetQua.Text = "";
		}
		public void SetDiemToan(double dToan)
		{
			thisinh.DiemToan = dToan;
			tbDiemTrungBinh.Text = thisinh.DiemTrungBinh.ToString();
			tbKetQua.Text = thisinh.KetQua;
		}
		public void SetDiemLy(double dLy)
		{
			thisinh.DiemLy = dLy;
			tbDiemTrungBinh.Text = thisinh.DiemTrungBinh.ToString();
			tbKetQua.Text = thisinh.KetQua;
		}
		public void SetDiemHoa(double dHoa)
		{
			thisinh.DiemHoa = dHoa;
			tbDiemTrungBinh.Text = thisinh.DiemTrungBinh.ToString();
			tbKetQua.Text = thisinh.KetQua;
		}
		
		void BtClearClick(object sender, EventArgs e)
		{
			ClearData();
		}
		
		void CbDiemToanSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				double dToan = double.Parse(cbDiemToan.Text);
				SetDiemToan(dToan);
			}catch
			{
				
			}
		}
		
		void CbDiemToanTextChanged(object sender, EventArgs e)
		{
			try
			{
				double dToan = double.Parse(cbDiemToan.Text);
				SetDiemToan(dToan);
			}catch
			{
				
			}
		}
		
		void CbDiemLySelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				double dLy = double.Parse(cbDiemLy.Text);
				SetDiemLy(dLy);
			}catch
			{
				
			}
		}
		
		void CbDiemLyTextChanged(object sender, EventArgs e)
		{
			try
			{
				double dLy = double.Parse(cbDiemLy.Text);
				SetDiemLy(dLy);
			}catch
			{
				
			}
		}
		
		void CbDiemHoaSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				double dHoa = double.Parse(cbDiemHoa.Text);
				SetDiemHoa(dHoa);
			}catch
			{
				
			}
		}
	}
}
