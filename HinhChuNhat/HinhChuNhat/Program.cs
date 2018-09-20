/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 06/09/2018
 * Time: 8:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HinhChuNhat
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			const int N = 2;
			int i;
			string [] sHoTen = new string[N];

			double [] dToan = new double[N],dVan=new double[N],dTrungBinh=new double[N];
			for(i=0; i<N;i++)
			{
				NhapThongTinHocSinh(out sHoTen[i], out dToan[i], out dVan[i], out dTrungBinh[i]);
			}
			HienThiThongTin(sHoTen, dToan, dVan,dTrungBinh,N);
			//Console.WriteLine("Hoc Sinh: {0} co diem toan {1}, diem van {2}, diem trung binh {3}",sHoTen, dToan, dVan, dTrungBinh);
			
			//InHinhChuNhat();
			//InHinhTamGiac();
			
//			const double MAX_WIDTH = 5.0f;
//			const double MIN_WIDTH = 0.75;
//			const double MAX_HEIGHT = 3.0f;
//			const double MIN_HEIGHT = 0.5f;
//			
//			double width, heigth;
//			Console.Write("Input Width: ");
//			width = double.Parse(Console.ReadLine());
//			Console.Write("Input Height: ");
//			heigth = double.Parse(Console.ReadLine());
//			
//			Console.WriteLine("Width is " + width);
//			Console.WriteLine("Heigth is " + heigth);
//			
//			if(width < MIN_WIDTH)
//			{
//				Console.WriteLine("Width is invalid ! It will be assigned to " +  MIN_WIDTH);
//				width = MIN_WIDTH;
//			}
//			
//			if(width > MAX_WIDTH)
//			{
//				Console.WriteLine("Width is invalid ! It will be assigned to " +  MAX_WIDTH);
//				width = MAX_WIDTH;
//			}
//			if(heigth < MIN_HEIGHT)
//			{
//				Console.WriteLine("Height is invalid ! It will be assigned to " + MIN_HEIGHT);
//				heigth = MIN_HEIGHT;
//			}
//			if(heigth > MAX_HEIGHT)
//			{
//				Console.WriteLine("Height is invalid ! It will be assigned to " + MAX_HEIGHT);
//				heigth = MAX_HEIGHT;
//			}
//			// TODO: Implement Functionality Here
//			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void NhapThongTinHocSinh( out string sHoTen, out double dToan, out double dVan, out double dTrungBinh)
		{
			Console.Write("Nhap Ho Ten: ");
			sHoTen = Console.ReadLine();
			
			Console.Write("Nhap diem toan: ");
			dToan = double.Parse(Console.ReadLine());
			
			Console.Write("Nhap diem van: ");
			dVan = double.Parse(Console.ReadLine());
			
			dTrungBinh=(dToan+dVan)/2;
		}
		
		static void HienThiThongTin(string [] sHoTen, double [] dToan, double [] dVan, double [] dTrungBinh, int N)
		{
			int i;
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("|     Ho Va Ten          | Diem Toan | Diem Van | Diem Trung Binh |");
			Console.WriteLine("-------------------------------------------------------------------");
			for(i =0; i<N ; i++)
			{
				Console.WriteLine("| {0,-22} |    {1,3}    |   {2,3}    |       {3,3}       |", sHoTen[i],dToan[i],dVan[i],dTrungBinh[i]);
			}
			Console.WriteLine("-------------------------------------------------------------------");
		}
		
		static void InHinhChuNhat()
		{
			const int MIN_N = 3;
			const int MAX_N = 10;
			int i,j,n,m;
			
			do
			{
				Console.Write("Nhap N [{0},{1}]:",MIN_N, MAX_N);
				n=int.Parse(Console.ReadLine());
			}while (n<MIN_N||n>MAX_N);
			
			do
			{
				Console.Write("Nhap M [{0},{1}]:",MIN_N, MAX_N);
				m=int.Parse(Console.ReadLine());
			}while (m<MIN_N||m>MAX_N);
			
			for(i=0;i<n;i++)
			{
				for(j=0;j<m;j++)
				{
					Console.Write(" * ");
				}
				Console.WriteLine();
			}
		}
		static void InHinhTamGiac()
		{
			const int MIN_N = 3;
			const int MAX_N = 10;
			int i,j,n;
			
			do
			{
				Console.Write("Nhap N [{0},{1}]:",MIN_N, MAX_N);
				n=int.Parse(Console.ReadLine());
			}while (n<MIN_N||n>MAX_N);
			
			for(i=1;i<=n;i++)
			{
				for(j=1;j<=2*n-1;j++)
				{
					if(j<=n-i||j>=n+i)
						Console.Write("   ");
					else
						Console.Write(" * ");
				}
				Console.WriteLine();
			}
		}
	}
}