/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 04/10/2018
 * Time: 8:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace HoanVi
{
	class Program
	{
		static void HoanVi(List<char> a, List<char> b)
		{
			char t;
			int i;
			if(a.Count == 1)
			{
				t=a[0];
				b.Add(t);
				PrintList(b);
				b.RemoveAt(b.Count-1);
			}
			else
			{
				for(i=0;i<a.Count;i=i+1)
				{
					t=a[i];
					a.RemoveAt(i);
					b.Add(t);
					HoanVi(a,b);
					a.Insert(i,t);
					b.RemoveAt(b.Count-1);
				}
			}
		}
		static void PrintList(List<char> a)
		{
			int i;
			for(i=0;i<a.Count;i=i+1)
			{
				Console.Write(a[i]);
			}
			Console.WriteLine();
			
		}
		public static void Main(string[] args)
		{
			List<char> a = new List<char>(), b = new List<char>();
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			a.Add('h');
			a.Add('r');
			a.Add('a');
			a.Add('d');
			
			HoanVi(a,b);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}