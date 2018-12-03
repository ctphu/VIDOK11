/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/12/2018
 * Time: 4:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace OOP01
{
	/// <summary>
	/// Description of VIDOUtils.
	/// </summary>
	public class VIDOUtils
	{
		public VIDOUtils()
		{
		}
		public double ReadNumber(string Message, double Min, double Max)
		{
			double result = 0;
			do
			{
				try
				{
					Console.Write(Message);
					result = double.Parse(Console.ReadLine());
				}catch(Exception ex)
				{
					Console.WriteLine("Input is not correct !");
					//Console.WriteLine(ex.ToString());
				}
			}while (result < Min || result > Max);
			
			return result;
		}
		public int ReadNumber(string Message, int Min, int Max)
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
		public int DisplayMenu(List<string> menu)
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
	}
}
