/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 01/11/2018
 * Time: 9:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HelloWorldWindows
{
	/// <summary>
	/// Description of clsThiSinh.
	/// </summary>
	public class clsThiSinh
	{
		public string MaSo{get;set;}
		public string HoTen{get;set;}
		public double DiemToan{get;set;}
		public double DiemLy{get;set;}
		public double DiemHoa{get;set;}
		public double DiemTrungBinh{get{return (DiemToan+DiemLy+DiemHoa)/3;}}
		public string KetQua
		{
			get
			{
				if(DiemTrungBinh>=5)
				{
					return "Dau";
				}
				else
				{
					return "Rot";
				}
			}
		}
		public clsThiSinh()
		{
			DiemToan = 0;
			DiemLy = 0;
			DiemHoa = 0;
		}
		public clsThiSinh(double dToan, double dLy, double dHoa)
		{
			DiemToan = dToan;
			DiemLy = dLy;
			DiemHoa = dHoa;
		}
	}
}
