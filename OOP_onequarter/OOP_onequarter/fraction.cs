/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/6/2018
 * Time: 9:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP_onequarter
{
	/// <summary>
	/// Description of fraction.
	/// </summary>
	public class fraction
	{
		private int itop, ibottom;
		public int top{
			get
			{
				return itop;
			}
			set
			{
				itop = value;
			}
		}
		public int bottom{
			get
			{
				return ibottom;
			}
			set
			{
				if (ibottom == 0)
				{
					ibottom = 1;
				}
				else
				{
					ibottom = value;
				}
			}
		}
		private int ucln (int a, int b)
		{
			int min;
			if (Math.Abs(a) > Math.Abs(b))
			{
				min = Math.Abs(a);
			}
			else min = Math.Abs(b);
			do
			{
				if(a % min ==0 && b % min == 0)
				{
					break;
				}
				min--;
			}while(min > 1);
			return min;
		}
		public fraction()
		{
			ibottom = 1;
			itop = 0;
		}
		public fraction (int paraTop, int paraBottom)
		{
			bottom = paraBottom;
			top = paraTop;			
		}
		public static fraction Plus(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.itop = a.itop*b.ibottom + a.ibottom*b.itop;
			c.ibottom = a.ibottom * b.ibottom;
			c.PSEnd();
			return c;
		}
		public static fraction Subtract(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.itop = a.itop*b.ibottom - a.ibottom*b.itop;
			c.ibottom = a.ibottom * b.ibottom;
			c.PSEnd();
			return c;
		}
		public static fraction Multilpe(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.itop = a.itop * b.itop;
			c.ibottom = a.ibottom * b.ibottom;
			c.PSEnd();
			return c;
		}
		public static fraction Div(fraction a, fraction b)
		{
			fraction c = new fraction();
			c.itop = a.itop * b.ibottom;
			c.ibottom = a.ibottom * b.itop;
			c.PSEnd();
			return c;
		}
		public void PSEnd()
		{
			int a = ucln(itop, ibottom);
			if (a != 0)
			{
				if (a > 0)
				{
					itop = itop / a;
					ibottom = ibottom /a;
					if (itop == 0)
					{
						ibottom = 0;
					}
				}
				if (a < 0)
				{
					itop = itop / (-a);
					ibottom = ibottom / (-a);
				}
			}
			
		}
	}
}
