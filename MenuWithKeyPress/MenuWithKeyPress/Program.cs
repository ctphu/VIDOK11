/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 04/10/2018
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace MenuWithKeyPress
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
		public static void Main(string[] args)
		{
			List<string> s = new List<string>();
			s.Add("1. Ga Ran");
			s.Add("2. Bo Go");
			s.Add("3. Thoat");
			switch(DisplayMenu(s))
			{
				case 0:
					Console.WriteLine("Ban chon ga ran");
					break;
				case 1:
					Console.WriteLine("Ban chon bo go");
					break;
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}