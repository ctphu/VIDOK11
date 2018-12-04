/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 04/12/2018
 * Time: 9:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of ThiSinhKC.
	/// </summary>
	public class ThiSinhKC:ThiSinh
	{
		public double DiemVan, DiemSu, DiemDia;
		public ThiSinhKC()
		{
		}
		public override void NhapThongTin()
		{
			VIDOUtils utils = new VIDOUtils();
			base.NhapThongTin();
			DiemVan = utils.ReadNumber("Nhap Diem Van:",0,10);
			DiemSu = utils.ReadNumber("Nhap Diem Su:",0,10);
			DiemDia = utils.ReadNumber("Nhap Diem Dia:",0,10);
			TongDiem = DiemDia + DiemSu + DiemVan;
		}
		public override string ToString()
		{
			return base.ToString()+string.Format("[ThiSinhKC DiemVan={0}, DiemSu={1}, DiemDia={2}]", DiemVan, DiemSu, DiemDia);
		}

	}
}
