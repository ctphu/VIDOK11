/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/12/2018
 * Time: 3:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of ThiSinhKD.
	/// </summary>
	public class ThiSinhKD:ThiSinh
	{
		public double DiemToan, DiemVan, DiemAnh;
		public ThiSinhKD()
		{
		}
		public override void NhapThongTin()
		{
			VIDOUtils utils = new VIDOUtils();
			base.NhapThongTin();
			DiemToan = utils.ReadNumber("Nhap Diem Toan: ",0,10);
			DiemVan = utils.ReadNumber("Nhap Diem Van: ",0,10);
			DiemAnh = utils.ReadNumber("Nhap Diem Anh: ",0,10);
			
			TongDiem = DiemToan + DiemVan + DiemAnh;
		}
		public override string ToString()
		{
			return base.ToString()+string.Format("[ThiSinhKD DiemToan={0}, DiemVan={1}, DiemAnh={2}]", DiemToan, DiemVan, DiemAnh);
		}

	}
}
