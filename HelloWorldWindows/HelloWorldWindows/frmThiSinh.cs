/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 01/11/2018
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;


namespace HelloWorldWindows
{
	/// <summary>
	/// Description of frmThiSinh.
	/// </summary>
	public partial class frmThiSinh : Form
	{
		clsThiSinh thisinh = new clsThiSinh();
		List<clsThiSinh> dsThiSinh = new List<clsThiSinh>();
		BindingList<clsThiSinh> bindingList;
		BindingSource source;
		public frmThiSinh()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bindingList = new BindingList<clsThiSinh>(dsThiSinh);
			source = new BindingSource(bindingList, null);
			dgThiSinh.DataSource = source;
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
		public void ShowData(clsThiSinh ts)
		{
			tbMaSo.Text = ts.MaSo;
			tbHoTen.Text = ts.HoTen;
			cbDiemToan.Text = ts.DiemToan.ToString();
			cbDiemLy.Text = ts.DiemLy.ToString();
			cbDiemHoa.Text = ts.DiemHoa.ToString();
			tbDiemTrungBinh.Text = ts.DiemTrungBinh.ToString();
			tbKetQua.Text = ts.KetQua;
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
		
		void BtAddClick(object sender, EventArgs e)
		{
			thisinh.MaSo = tbMaSo.Text;
			thisinh.HoTen = tbHoTen.Text;			
			source.Add(thisinh);
			//dsThiSinh.Add(thisinh);
			//dgThiSinh.
			//dgThiSinh.DataSource = dsThiSinh;
			thisinh = new clsThiSinh();
			ClearData();
			dgThiSinh.Refresh();
		}
		
		void DgThiSinhCurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dgThiSinh.CurrentRowIndex];
				if(row != null)
				{
					var currentThiSinh = (clsThiSinh)row;
					ShowData(currentThiSinh);
				}
			}catch
			{
				
			}
		}
		
		void BtSuaClick(object sender, EventArgs e)
		{
			thisinh.MaSo = tbMaSo.Text;
			thisinh.HoTen = tbHoTen.Text;
			source[dgThiSinh.CurrentRowIndex] = thisinh;
			//source.Add(thisinh);
			thisinh = new clsThiSinh();
			ClearData();
			dgThiSinh.Refresh();
		}
		
		void BtXoaClick(object sender, EventArgs e)
		{
			try
			{
				clsThiSinh currentThiSinh = (clsThiSinh)source[dgThiSinh.CurrentRowIndex];
				source.RemoveAt(dgThiSinh.CurrentRowIndex);
				
//				JavaScriptSerializer serializer = new JavaScriptSerializer();
//				var json = serializer.Serialize(currentThiSinh);
//				MessageBox.Show(json);
//				
//				var deserializeObject = serializer.Deserialize<clsThiSinh>(json);
//				clsThiSinh newThiSinh = (clsThiSinh)deserializeObject;
//				ShowData(newThiSinh);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void FrmThiSinhLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Json Files|*.json|All Files|*.*";
			if(save.ShowDialog() == DialogResult.OK)
			{
				string sFileName = save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(dsThiSinh);
				StreamWriter writer ;
				writer = new StreamWriter(sFileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("Saved !");
			}
		}
		
		void BtnLoadClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Json Files|*.json|All Files|*.*";
			if(open.ShowDialog() == DialogResult.OK)
			{
				string sFileName = open.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var deserializeObject = serializer.Deserialize<List<clsThiSinh>>(json);
				source.Clear();
				foreach (var element in deserializeObject) {
					source.Add(element);
				}
				MessageBox.Show("Load OK !");
			}
		}
	}
}
