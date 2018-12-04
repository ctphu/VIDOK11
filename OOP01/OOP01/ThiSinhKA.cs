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
			VIDOUtils utils = new VIDOUtils();
			base.NhapThongTin();
			DiemToan = utils.ReadNumber("Nhap Diem Toan: ",0,10);
			DiemLy = utils.ReadNumber("Nhap Diem Ly: ",0,10);
			DiemHoa = utils.ReadNumber("Nhap Diem Hoa: ",0,10);
			TongDiem = DiemToan + DiemLy + DiemHoa;
		}
		public override string ToString()
		{
			return base.ToString()+string.Format("[ThiSinhKA DiemToan={0}, DiemLy={1}, DiemHoa={2}]", DiemToan, DiemLy, DiemHoa);
		}

	}
}
