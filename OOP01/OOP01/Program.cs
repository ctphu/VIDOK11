/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/12/2018
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace OOP01
{
	class Program
	{
		public static void Main(string[] args)
		{
			VIDOUtils utils = new VIDOUtils();
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			List<ThiSinh> listThiSinh = new List<ThiSinh>();
			ThiSinh ts;
			List<string> s = new List<string>();
			int index,i;
			s.Add("1. Nhap Thi Sinh Khoi A");
			s.Add("2. Nhap Thi Sinh Khoi C");
			s.Add("3. Nhap Thi Sinh Khoi D");
			s.Add("4. Danh Sach Thi Sinh");
			s.Add("5. Thoat");
			do
			{
				index = utils.DisplayMenu(s);
				switch(index)
				{
					case 0:
						ts = new ThiSinhKA();
						ts.NhapThongTin();
						listThiSinh.Add(ts);
						break;
					case 1:
						
						break;
					case 2:						
						ts = new ThiSinhKD();
						ts.NhapThongTin();
						listThiSinh.Add(ts);
						break;
					case 3:
						foreach (var element in listThiSinh) {
							Console.WriteLine(element.ToString());
						}
						Console.ReadKey(true);
						break;
				
				}
			}while (index != 4);
			
//			Animal a, b;
//			Animal c;
//			Animal d;
//			a = new Animal();
//			b = new Animal("Cat");
//			c = new Cat();
//			d = new Duck();
//			
//			d.Sleep();
//			d.Move();
//			
//			c.Sleep();
//			c.Move();
//			
//			Console.WriteLine(a.ToString());
//			Console.WriteLine(b.ToString());
//			Console.WriteLine(c.ToString());
//			a.Move();
//			b.Move();
//			c.Move();
//			((Cat)c).Say();
//			a.Sleep();
//			b.Sleep();
//			c.Sleep();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}