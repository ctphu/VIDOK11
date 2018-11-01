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
using System.Linq;

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
		
		static clsCauThu NhapCauThu()
		{
			clsCauThu a = new clsCauThu();
			Console.Write("Nhap Ma Cau Thu: ");
			a.MaCauThu = Console.ReadLine();
			Console.Write("Nhap Ten Cau Thu: ");
			a.TenCauThu = Console.ReadLine();
			do
			{
				try
				{
					Console.Write("Nhap Ngay Sinh:");
					a.NgaySinh = DateTime.Parse(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Nhap sai ngay sinh vui long nhap lai");
					a.NgaySinh = DateTime.Today;
				}
			}
			while(a.NgaySinh > DateTime.Today.AddYears(-12));
			return a;
		}
		
		static void HienThiThongTin(List<clsCauThu> dsCauThu)
		{
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("|    Ma So   |              Ten               |  Ngay Sinh | Tuoi |");
			Console.WriteLine("-------------------------------------------------------------------");
			foreach (var element in dsCauThu) 
			{
				Console.WriteLine("| {0,-10} | {1,-30} | {2,10} |  {3,2}  |", element.MaCauThu,element.TenCauThu,element.NgaySinh.ToString("dd/MM/yyyy"), DateTime.Today.Year -element.NgaySinh.Year);
			}
			Console.WriteLine("-------------------------------------------------------------------");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static void HienThiThongTinCauThuNhoTuoiNhat(List<clsCauThu> dsCauThu)
		{
			clsCauThu min = dsCauThu[0];
			int i;
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("|    Ma So   |              Ten               |  Ngay Sinh | Tuoi |");
			Console.WriteLine("-------------------------------------------------------------------");
			foreach (var element in dsCauThu) 
			{
				Console.WriteLine("| {0,-10} | {1,-30} | {2,10} |  {3,2}  |", element.MaCauThu,element.TenCauThu,element.NgaySinh.ToString("dd/MM/yyyy"), DateTime.Today.Year -element.NgaySinh.Year);
				i = min.NgaySinh.CompareTo(element.NgaySinh);
				//j = Math.Abs(DateTime.Today.CompareTo(min.NgaySinh));
				if(min.NgaySinh.CompareTo(element.NgaySinh)==-1)
				{
					min = element;
				}
			}
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("| {0,-10} | {1,-30} | {2,10} |  {3,2}  |", min.MaCauThu,min.TenCauThu,min.NgaySinh.ToString("dd/MM/yyyy"), DateTime.Today.Year -min.NgaySinh.Year);
			Console.WriteLine("-------------------------------------------------------------------");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void SapSepDanhSachCauThu(List<clsCauThu> dsCauThu)
		{
			int i,j;
			clsCauThu t;
			for(i=0;i<dsCauThu.Count-1;i=i+1)
			{
				for(j=i+1;j<dsCauThu.Count;j=j+1)
				{
					if(dsCauThu[i].NgaySinh.CompareTo(dsCauThu[j].NgaySinh)==-1)
					{
						t = dsCauThu[j];
						dsCauThu[j] = dsCauThu[i];
						dsCauThu[i] = t;
					}
				}
			}

			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("|    Ma So   |              Ten               |  Ngay Sinh | Tuoi |");
			Console.WriteLine("-------------------------------------------------------------------");
			foreach (var element in dsCauThu) 
			{
				Console.WriteLine("| {0,-10} | {1,-30} | {2,10} |  {3,2}  |", element.MaCauThu,element.TenCauThu,element.NgaySinh.ToString("dd/MM/yyyy"), DateTime.Today.Year -element.NgaySinh.Year);
			}
			Console.WriteLine("-------------------------------------------------------------------");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void SapSepDanhSachCauThu1(List<clsCauThu> dsCauThu)
		{
			List<clsCauThu> sort = dsCauThu.OrderBy(ct => ct.NgaySinh).ToList();
			//List<clsCauThu> sort = dsCauThu.OrderByDescending(ct => ct.NgaySinh).ToList();
			
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("|    Ma So   |              Ten               |  Ngay Sinh | Tuoi |");
			Console.WriteLine("-------------------------------------------------------------------");
			foreach (var element in sort) 
			{
				Console.WriteLine("| {0,-10} | {1,-30} | {2,10} |  {3,2}  |", element.MaCauThu,element.TenCauThu,element.NgaySinh.ToString("dd/MM/yyyy"), DateTime.Today.Year -element.NgaySinh.Year);
			}
			Console.WriteLine("-------------------------------------------------------------------");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
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
			List<clsCauThu> dsCauThu = new List<clsCauThu>();
			int index,i;
			s.Add("1. Nhap Cau Thu");
			s.Add("2. Xuat danh sach");
			s.Add("3. Tim cau thu nho tuoi nhat");
			s.Add("4. Sap sep");
			s.Add("4. Sap sep1");
			s.Add("5. Thoat");
			do
			{
				index = DisplayMenu(s);
				switch(index)
				{
					case 0:
						dsCauThu.Add(NhapCauThu());
						break;
					case 1:
						HienThiThongTin(dsCauThu);
						break;
					case 2:
						HienThiThongTinCauThuNhoTuoiNhat(dsCauThu);
						//TimMatHang(dsMatHang);
						break;
					case 3:
						SapSepDanhSachCauThu(dsCauThu);
						//LocMatHang(dsMatHang);
						break;
					case 4:
						SapSepDanhSachCauThu1(dsCauThu);
						//LocMatHang(dsMatHang);
						break;
				
				}
			}while (index != 5);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}