/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/12/2018
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of ThiSinhKA.
	/// </summary>
	public class ThiSinhKA:ThiSinh
	{
		double DiemToan, DiemLy, DiemHoa;
		public ThiSinhKA()
		{
		}
		public override void NhapThongTin()
		{
			base.NhapThongTin();
			Console.Write("Nhap Diem Toan:");
			DiemToan = double.Parse(Console.ReadLine());
			Console.Write("Nhap Diem Hoa:");
			DiemHoa = double.Parse(Console.ReadLine());
			Console.Write("Nhap Diem Ly:");
			DiemLy = double.Parse(Console.ReadLine());
			TongDiem = DiemToan + DiemLy + DiemHoa;
		}
		public override string ToString()
		{
			return base.ToString()+string.Format("[ThiSinhKA DiemToan={0}, DiemLy={1}, DiemHoa={2}]", DiemToan, DiemLy, DiemHoa);
		}

	}
}
