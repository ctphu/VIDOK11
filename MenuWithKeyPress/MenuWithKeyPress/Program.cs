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
	public struct Menu{
		public string Name;
		public int Price;
	}
	class Program
	{
		static int DisplayMenu(List<string> menu, List<Menu> orders)
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
				DisplayOrder(orders);
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
		static void DisplayOrder(List<Menu> orders)
		{
			foreach (var element in orders) {
				Console.WriteLine("Ban da chon {0} voi gia {1}",element.Name,element.Price);
			}
		}
		public static void Main(string[] args)
		{
			List<Menu> order = new List<Menu>();
			Menu item;
			List<string> s = new List<string>();
			int index,i;
			s.Add("1. Ga Ran (30)");
			s.Add("2. Bo Go (35)");
			s.Add("3. Thoat");
			do
			{
				index = DisplayMenu(s,order);
				switch(index)
				{
					case 0:
						//Console.WriteLine("Ban chon ga ran gia (30)");
						item = new Menu();
						item.Name = "Ga Ran";
						item.Price = 30;
						order.Add(item);
						break;
					case 1:
						//Console.WriteLine("Ban chon bo go");
						item = new Menu();
						item.Name = "Bo Go";
						item.Price = 35;
						order.Add(item);
						break;
				}
			}while (index != 2);
			Console.Clear();
			DisplayOrder(order);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}