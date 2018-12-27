/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 27/12/2018
 * Time: 11:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VIDOPaint
{
	/// <summary>
	/// Description of clsLine.
	/// </summary>
	public class clsLine : clsHinh
	{
		public clsLine()
		{
		}
		public clsLine(clsDiem d1, clsDiem d2)
		{
			D1 = d1;
			D2 = d2;
		}
		public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen p)
		{
			g.DrawLine(p,D1.X,D1.Y,D2.X,D2.Y);
		}
	}
}
