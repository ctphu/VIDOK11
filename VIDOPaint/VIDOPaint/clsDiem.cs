/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 27/12/2018
 * Time: 9:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VIDOPaint
{
	/// <summary>
	/// Description of clsDiem.
	/// </summary>
	public class clsDiem
	{
		int ix, iy;
		public int X
		{
			get
			{
				return ix;
			}
			set
			{
				ix = value;
			}
		}
		public int Y
		{
			get
			{
				return iy;
			}
			set
			{
				iy = value;
			}
		}
		public clsDiem()
		{
			X=0;
			Y=0;
		}
		public clsDiem(int a, int b)
		{
			X = a;
			Y = b;
		}
	}
}
