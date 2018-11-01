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
using System.IO;

namespace MenuWithKeyPress
{
	public struct Menu{
		public string Name;
		public int Price;
	}
	class Program
	{
		static StreamWriter writer; 
		static bool CheckPosition(int row, int col, List<int> rows, List<int> cols, List<int> condition1, List<int> condition2)
		{
			// check row
			if(rows.IndexOf(row)>=0)
			{
				return false;
			}
			if(cols.IndexOf(col)>=0)
			{
				return false;
			}
			if(condition1.IndexOf(row-col)>=0)
			{
				return false;
			}
			if(condition2.IndexOf(row+col)>=0)
			{
				return false;
			}
			return true;
		}
		static bool Queen(int Order, List<int> rows, List<int> cols, List<int> condition1, List<int> condition2, List<string> sCurrentPosition )
		{
			int i, j;
			if(Order == 8)
			{
				for(i=Order-1;i<8;i=i+1)
				{
					for(j=0;j<8;j=j+1)
					{
						if(CheckPosition(i,j,rows, cols, condition1, condition2))
						{
							sCurrentPosition.Add(string.Format("[{0},{1}]",i,j));
							foreach (var element in sCurrentPosition) {
								writer.Write(element);
							}
							writer.WriteLine();
							sCurrentPosition.RemoveAt(sCurrentPosition.Count - 1);
							//Console.ReadKey(true);
							return true;
						}   
					}
				}
				return false;
			}
			else
			{
				for(i=Order-1;i<8;i=i+1)
				{
					for(j=0;j<8;j=j+1)
					{
						if(CheckPosition(i,j,rows, cols, condition1, condition2))
						{
							sCurrentPosition.Add(string.Format("[{0},{1}]",i,j));
							rows.Add(i);
							cols.Add(j);
							condition1.Add(i-j);
							condition2.Add(i+j);
							Queen(Order + 1,rows,cols,condition1,condition2,sCurrentPosition);
							rows.RemoveAt(rows.Count-1);
							cols.RemoveAt(cols.Count-1);
							condition1.RemoveAt(condition1.Count-1);
							condition2.RemoveAt(condition2.Count-1);
							sCurrentPosition.RemoveAt(sCurrentPosition.Count - 1);
						}   
					}
				}
				return false;
			}
		}
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
			writer = new StreamWriter("queen.txt");
			List<int> rows = new List<int>();
			List<int> cols = new List<int>();
			List<int> condition1 = new List<int>();
			List<int> condition2 = new List<int>();
			List<string> sResult = new List<string>();
			
			List<Menu> order = new List<Menu>();
			Menu item;
			List<string> s = new List<string>();
			int index,i;
			s.Add("1. Ga Ran (30)");
			s.Add("2. Bo Go (35)");
			s.Add("3. Queen");
			s.Add("4. Thoat");
			do
			{
				index = DisplayMenu(s,order);
				switch(index)
				{
					case 0:
						//Console.WriteLine("Ban chon ga ran gia (30)");
						//item = new Menu();
						item.Name = "Ga Ran";
						item.Price = 30;
						order.Add(item);
						break;
					case 1:
						//Console.WriteLine("Ban chon bo go");
						//item = new Menu();
						item.Name = "Bo Go";
						item.Price = 35;
						order.Add(item);
						break;
					case 2:
						Queen(1,rows,cols,condition1, condition2, sResult);
						writer.Close();
						//Console.ReadKey(true);
						break;
				
				}
			}while (index != 3);
			Console.Clear();
			DisplayOrder(order);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	
}