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
	struct Point{
		public int X;
		public int Y;
	}
	class Program
	{
		const int ROWS = 24;
		const int COLS = 80;
		static void Move(int N, char From, char To)
		{
			Console.WriteLine("Move {0} From {1} To {2}", N, From, To);
		}
		
		static void HNT(int N, char From, char Temp, char To)
		{
			if(N==1)
				Move(N,From,To);
			else
			{
				HNT(N-1,From,To,Temp);
				Move(N,From,To);
				HNT(N-1,Temp, From, To);
			}
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
		
//		public static void HoanVi(int [] array, int index, int N)
//		{
//			for(int i = index; i < N; i++)
//			{
//				Console.Write(array[i]);
//				HoanVi(array,index+1,N);
//				Console.WriteLine();
//			}
//		}
		static void DisplayScreen(int [,] screen)
		{
			int i,j;
			Console.Clear();
			for(i=0;i<ROWS;i++)
			{
				for(j=0;j<COLS;j++)
				{
					if(screen[i,j] == 1)
						Console.Write("*");
					else
						Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
		public static void Main(string[] args)
		{
			int [,] screen = new int[ROWS,COLS];
			int i,j;
			Point index, indexNew;
			ConsoleKeyInfo kb;
			index.X = 5;
			index.Y = 5;
			indexNew = index;
			for(i=0;i<ROWS;i++)
			{
				for(j=0;j<COLS;j++)
				{
					if(i==0 || j==0 || i==ROWS-1|| j==COLS-1)
					{
						screen[i,j] = 1;
					}
					else
					{
						screen[i,j]= 0;
					}
					if(i==index.X&&j==index.Y)
					{
						screen[i,j] = 1;
					}
				}
			}
			Console.CursorVisible = false;
			DisplayScreen(screen);
			
			do{
				kb = Console.ReadKey();
				if(kb.Key == ConsoleKey.UpArrow)
				{
					if(index.X==1)
						indexNew.X=ROWS-2;
					else
						indexNew.X=index.X-1;
					indexNew.Y = index.Y;
				}
				
				screen[index.X,index.Y] = 0;
				
				Console.CursorTop = index.X;
				Console.CursorLeft = index.Y;
				Console.Write(" ");
				
				index = indexNew;
				screen[index.X,index.Y] = 1;
				
				Console.CursorTop = index.X;
				Console.CursorLeft = index.Y;
				Console.Write("*");
				
				//DisplayScreen(screen);
			}while (kb.Key != ConsoleKey.Escape);
			
			
//			int N;
//			N = ReadNumber("Input N [3,10]:", 3,10);
//			HNT(N,'A','B','C');
			
//			const int N = 1;
//			int i;
//			
//			int [] array = new int[3];
//			array[0]=1;
//			array[1]=2;
//			array[2]=3;
//			HoanVi(array,0,3);
			
//			HocSinh [] hocsinh = new HocSinh[N];
//			for(i = 0 ; i<N ; i++)
//			{
//				hocsinh[i] = new HocSinh();
//				hocsinh[i].NhapThongTin();
//				hocsinh[i].TinhDiemTrungBinh();
//			}
//			HienThiThongTin(hocsinh,N);
			
			
			/* Code cu
			
			string [] sHoTen = new string[N];

			double [] dToan = new double[N],dVan=new double[N],dTrungBinh=new double[N];
			for(i=0; i<N;i++)
			{
				NhapThongTinHocSinh(out sHoTen[i], out dToan[i], out dVan[i], out dTrungBinh[i]);
			}
			HienThiThongTin(sHoTen, dToan, dVan,dTrungBinh,N);
			
			*/
			
			
			
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
		
		static void HienThiThongTin(HocSinh [] hocsinh, int N)
		{
			int i;
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("|     Ho Va Ten          | Diem Toan | Diem Van | Diem Trung Binh |");
			Console.WriteLine("-------------------------------------------------------------------");
			for(i =0; i<N ; i++)
			{
				Console.WriteLine("| {0,-22} |    {1,3}    |   {2,3}    |       {3,3}       |", hocsinh[i].HoTen,hocsinh[i].DiemToan,hocsinh[i].DiemVan,hocsinh[i].DiemTrungBinh);
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
	
	class HocSinh
	{
		public string HoTen;
		public DateTime NgaySinh;
		public double DiemToan, DiemVan, DiemTrungBinh;
		
		public void NhapThongTin()
		{
			Console.Write("Nhap Ho Ten: ");
			HoTen = Console.ReadLine();
			
			Console.Write("Nhap Ngay Sinh: ");
			NgaySinh = DateTime.Parse(Console.ReadLine());
			
			Console.Write("Nhap diem toan: ");
			DiemToan = double.Parse(Console.ReadLine());
			
			Console.Write("Nhap diem van: ");
			DiemVan = double.Parse(Console.ReadLine());
		}
		
		public void TinhDiemTrungBinh()
		{
			DiemTrungBinh=(DiemToan+DiemVan)/2;
		}
	}
}