/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 11/10/2018
 * Time: 8:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace BT670
{
	class Program
	{
		static int DisplayMenu(List<string> menu)
		{
			int i, index = 0;
			ConsoleKeyInfo kb;
        
			do
			{
				Console.Clear();
				for(i=0;i<menu.Count;i=i+1)
				{
					if(i==index)
						Console.Write("* ");
					else
						Console.Write("  ");
					Console.WriteLine(menu[i]);
				}
				kb = Console.ReadKey();
				if (kb.Key == ConsoleKey.UpArrow)
				{
					if(index == 0)
						index = menu.Count - 1;
					else
						index = index - 1;
				}
				else if (kb.Key == ConsoleKey.DownArrow
				        )
				{
					if(index == menu.Count - 1)
						index = 0;
					else
						index = index + 1;
				}
				else if (kb.Key == ConsoleKey.Enter)
				{
					break;
				}
                	
			}while(true);
			return index;
		}
		
		static int ReadNumber(string Message, int Min, int Max)
		{
			int result = 0;
			do
			{
				try
				{
					Console.Write(Message);
					result = int.Parse(Console.ReadLine());
				}catch(Exception ex)
				{
					Console.WriteLine("Input is not correct !");
					//Console.WriteLine(ex.ToString());
				}
			}while (result < Min || result > Max);
			
			return result;
		}
		
		static clsMatHang NhapMatHang()
		{
			clsMatHang a = new clsMatHang();
			Console.Write("Nhap Ten Mat Hang: ");
			a.TenMatHang = Console.ReadLine();
			a.DonGia = ReadNumber("Nhap Don Gia: ",1,1000000);
			a.SoLuongTon =ReadNumber("Nhap So Luong Ton: ",1, 10000);
			return a;
		}
		static void HienThiThongTin(List<clsMatHang> dsMatHang)
		{
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine("|     Ten Mat Hang      | So Luong Ton |    Don Gia   |    Gia Tri   |");
			Console.WriteLine("----------------------------------------------------------------------");
			foreach (var element in dsMatHang) 
			{
				Console.WriteLine("| {0,-21} | {1,12:# ### ###} | {2,12:# ### ###} | {3,12:# ### ###} |", element.TenMatHang,element.SoLuongTon,element.DonGia,element.SoLuongTon*element.DonGia);
			}
			Console.WriteLine("----------------------------------------------------------------------");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void TimMatHang(List<clsMatHang> dsMatHang)
		{
			clsMatHang max = new clsMatHang();
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine("|     Ten Mat Hang      | So Luong Ton |    Don Gia   |    Gia Tri   |");
			Console.WriteLine("----------------------------------------------------------------------");
			max = dsMatHang[0];
			foreach (var element in dsMatHang) 
			{
				Console.WriteLine("| {0,-21} | {1,12:# ### ###} | {2,12:# ### ###} | {3,12:# ### ###} |", element.TenMatHang,element.SoLuongTon,element.DonGia,element.SoLuongTon*element.DonGia);
				if(element.SoLuongTon*element.DonGia > max.SoLuongTon*max.DonGia)
				{
					max = element;
				}
			}
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine("---------------------Mat Hang Co Gia Tri Lon Nhat---------------------");
			Console.WriteLine("| {0,-21} | {1,12:# ### ###} | {2,12:# ### ###} | {3,12:# ### ###} |", max.TenMatHang,max.SoLuongTon,max.DonGia,max.SoLuongTon*max.DonGia);
			Console.WriteLine("----------------------------------------------------------------------");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void LocMatHang(List<clsMatHang> dsMatHang)
		{
			List<clsMatHang> dsLoc = new List<clsMatHang>();
			
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine("|     Ten Mat Hang      | So Luong Ton |    Don Gia   |    Gia Tri   |");
			Console.WriteLine("----------------------------------------------------------------------");
			
			foreach (var element in dsMatHang) 
			{
				Console.WriteLine("| {0,-21} | {1,12:# ### ###} | {2,12:# ### ###} | {3,12:# ### ###} |", element.TenMatHang,element.SoLuongTon,element.DonGia,element.SoLuongTon*element.DonGia);
				if(element.SoLuongTon> 1000)
				{
					dsLoc.Add(element);
				}
			}
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine("------------------Danh sach mat hang ton > 1000 {0,5} ----------------",dsLoc.Count);
			Console.WriteLine("|     Ten Mat Hang      | So Luong Ton |    Don Gia   |    Gia Tri   |");
			Console.WriteLine("----------------------------------------------------------------------");
			foreach (var element in dsLoc) 
			{
				Console.WriteLine("| {0,-21} | {1,12:# ### ###} | {2,12:# ### ###} | {3,12:# ### ###} |", element.TenMatHang,element.SoLuongTon,element.DonGia,element.SoLuongTon*element.DonGia);				
			}
			Console.WriteLine("----------------------------------------------------------------------");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void Main(string[] args)
		{
			List<string> s = new List<string>();
			List<clsMatHang> dsMatHang = new List<clsMatHang>();
			int index,i;
			s.Add("1. Nhap mat hang");
			s.Add("2. Xuat danh sach");
			s.Add("3. Tim mat hang gia tri lon nhat");
			s.Add("4. Dem so luong mat hang");
			s.Add("5. Thoat");
			do
			{
				index = DisplayMenu(s);
				switch(index)
				{
					case 0:
						dsMatHang.Add(NhapMatHang());
						break;
					case 1:
						HienThiThongTin(dsMatHang);
						break;
					case 2:
						TimMatHang(dsMatHang);
						break;
					case 3:
						LocMatHang(dsMatHang);
						break;
				
				}
			}while (index != 4);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}