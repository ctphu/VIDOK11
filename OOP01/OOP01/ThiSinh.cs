/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/12/2018
 * Time: 3:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of ThiSinh.
	/// </summary>
	public class ThiSinh
	{
		public string MSTS;
		public string HoTen;
		public double TongDiem;
		public ThiSinh()
		{
		}
		public virtual void NhapThongTin()
		{
			Console.Write("Nhap MSTS:");
			MSTS = Console.ReadLine();
			Console.Write("Nhap Ho Ten:");
			HoTen = Console.ReadLine();
			
		}
		public override string ToString()
		{
			return string.Format("[ThiSinh MSTS={0}, HoTen={1}, TongDiem={2}]", MSTS, HoTen, TongDiem);
		}

	}
}
