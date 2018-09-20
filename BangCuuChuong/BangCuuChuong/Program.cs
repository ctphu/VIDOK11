/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 06/09/2018
 * Time: 10:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BangCuuChuong
{
	class Program
	{
		public static void Main(string[] args)
		{
			const int MIN_N = 2;
			const int MAX_N = 15;
			int n;
			
			do{
				Console.Write("Nhap N[{0},{1}]: ",MIN_N,MAX_N);
				n = int.Parse(Console.ReadLine());
			}while (n<MIN_N || n>MAX_N);
			
			Console.WriteLine("Bang cuu chuong " + n);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}