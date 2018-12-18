/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 18/12/2018
 * Time: 8:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BigInt
{
	/// <summary>
	/// Description of BigInt.
	/// </summary>
	public class BigInt
	{
		private string sValue;
		public string Value{
			get
			{
				return sValue;
			}
			set
			{
				if(string.IsNullOrWhiteSpace(value)||value=="-")
					sValue = "0";
				else
					sValue = value;
			}
		}
		public BigInt()
		{
			sValue = "0";
		}
		public bool IsMinus()
		{
			if(sValue.StartsWith("-"))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public string ABS()
		{
			string sResult;
			if(IsMinus() == true)
				sResult = sValue.Substring(1);
			else
				sResult = sValue;
			return sResult;
		}
		public static bool operator > (BigInt a, BigInt b)
		{
			if(a.IsMinus()==false && b.IsMinus()==true)
			{
				return true;
			}
			else if (a.IsMinus() == true && b.IsMinus()==false)
			{
				return false;
			}
			else if(a.IsMinus()==false)
			{
				if(a.sValue.Length > b.sValue.Length)
				{
					return true;
				}
				else if(a.sValue.Length < b.sValue.Length)
				{
					return false;
				}
				else
				{
					for (int i = 0; i < a.sValue.Length; i++) 
					{
						if(int.Parse(a.sValue.Substring(i,1))>int.Parse(b.sValue.Substring(i,1)))
							return true;
						else if(int.Parse(a.sValue.Substring(i,1))<int.Parse(b.sValue.Substring(i,1)))
							return false;
					}
					return false;
				}
			}
			else// ca hai deu la so am
			{
				if(a.sValue.Length > b.sValue.Length)
				{
					return false;
				}
				else if(a.sValue.Length < b.sValue.Length)
				{
					return true;
				}
				else
				{
					for (int i = 1; i < a.sValue.Length; i++) 
					{
						if(int.Parse(a.sValue.Substring(i,1))<int.Parse(b.sValue.Substring(i,1)))
							return true;
						else if(int.Parse(a.sValue.Substring(i,1))>int.Parse(b.sValue.Substring(i,1)))
							return false;
					}
					return false;
				}
			}
		}
		
		public static bool operator == (BigInt a, BigInt b)
		{
			if(a.sValue.Length != b.sValue.Length)
				return false;
			
			for (int i = 0; i < a.sValue.Length; i++) 
			{
				if(a.sValue.Substring(i, 1) != b.sValue.Substring(i,1))
					return false;
			}
			return true;
		}
		public static bool operator != (BigInt a, BigInt b)
		{
			if(a==b)
				return false;
			else
				return true;
		}
		
		public static bool operator < (BigInt a, BigInt b)
		{
			if(a > b)
				return false;
			else if (a == b)
				return false;
			else
				return true;
		}
		
		public static BigInt operator + (BigInt a, BigInt b)
		{
			BigInt c = new BigInt();
			int i, maxLength, iA, iB, iNho;
			string sA, sB, sC;
			string cA, cB, cC;
			if(a.IsMinus() == false && b.IsMinus() == false)
			{
				sA = a.sValue;
				sB = b.sValue;
				if(sA.Length > sB.Length)
				{
					maxLength = sA.Length;
					while (sA.Length != sB.Length) {
						sB = "0" + sB;
					}
				}
				else
				{
					maxLength = sB.Length;
					while (sA.Length != sB.Length) {
						sA = "0" + sA;
					}
				}
				
				iA = 0;
				iB = 0;
				iNho = 0;
				sC = "";
				for (i = 0; i < maxLength; i++) 
				{
					cA = sA.Substring(maxLength-1-i,1);
					cB = sB.Substring(maxLength-1-i,1);
					iA = int.Parse(cA);
					iB = int.Parse(cB);
					
					cC = ( iA + iB + iNho).ToString();
					if(cC.Length>1)
					{
						sC = cC.Substring(1,1) + sC;
						iNho = 1;
					}
					else
					{
						sC = cC + sC;
						iNho = 0;
					}
				}
				c.sValue = sC;
			}
			else if(a.IsMinus() == true && b.IsMinus() == true)
			{
				sA = a.ABS();
				sB = b.ABS();
				if(sA.Length > sB.Length)
				{
					maxLength = sA.Length;
					while (sA.Length != sB.Length) {
						sB = "0" + sB;
					}
				}
				else
				{
					maxLength = sB.Length;
					while (sA.Length != sB.Length) {
						sA = "0" + sA;
					}
				}
				
				iA = 0;
				iB = 0;
				iNho = 0;
				sC = "";
				for (i = 0; i < maxLength; i++) 
				{
					cA = sA.Substring(maxLength-1-i,1);
					cB = sB.Substring(maxLength-1-i,1);
					iA = int.Parse(cA);
					iB = int.Parse(cB);
					
					cC = ( iA + iB + iNho).ToString();
					if(cC.Length>1)
					{
						sC = cC.Substring(1,1) + sC;
						iNho = 1;
					}
					else
					{
						sC = cC + sC;
						iNho = 0;
					}
				}
				c.sValue = "-" + sC;
			}
			else if(a.IsMinus() == false && b.IsMinus() == true)
			{
				BigInt b1 = new BigInt();
				b1.Value = b.ABS();
				c = a - b1;
			}
			else if(a.IsMinus() == true && b.IsMinus() == false)
			{
				BigInt a1 = new BigInt();
				a1.Value = a.ABS();
				c = b - a1;
			}
			return c;
		}
		
		public static BigInt operator - (BigInt a, BigInt b)
		{
			BigInt c = new BigInt();
			int i, maxLength, iA, iB, iNho;
			string sA, sB, sC;
			string cA, cB, cC;
			if(a.IsMinus() == false && b.IsMinus() == false)
			{
				if(a>b || a==b)
				{
					sA = a.sValue;
					sB = b.sValue;
					maxLength = sA.Length;
					while (sA.Length != sB.Length) {
						sB = "0" + sB;
					}
					
					iA = 0;
					iB = 0;
					iNho = 0;
					sC = "";
					for (i = 0; i < maxLength; i++) 
					{
						cA = sA.Substring(maxLength-1-i,1);
						cB = sB.Substring(maxLength-1-i,1);
						iA = int.Parse(cA);
						iB = int.Parse(cB);
						if(iA>=(iB+iNho))
						{
							cC = ( iA - (iB + iNho)).ToString();
							iNho = 0;
						}
						else
						{
							cC = ( 10 + iA - (iB + iNho)).ToString();
							iNho = 1;
						}
						sC = cC + sC;
						
					}
					while (sC.StartsWith("0")) {
						sC = sC.Remove(0,1);
					}
					c.Value = sC;
				}
				else
				{
					sA = b.sValue;
					sB = a.sValue;
					maxLength = sA.Length;
					while (sA.Length != sB.Length) {
						sB = "0" + sB;
					}
					
					iA = 0;
					iB = 0;
					iNho = 0;
					sC = "";
					for (i = 0; i < maxLength; i++) 
					{
						cA = sA.Substring(maxLength-1-i,1);
						cB = sB.Substring(maxLength-1-i,1);
						iA = int.Parse(cA);
						iB = int.Parse(cB);
						if(iA>=(iB+iNho))
						{
							cC = ( iA - (iB + iNho)).ToString();
							iNho = 0;
						}
						else
						{
							cC = ( 10 + iA - (iB + iNho)).ToString();
							iNho = 1;
						}
						sC = cC + sC;
						
					}
					while (sC.StartsWith("0")) {
						sC = sC.Remove(0,1);
					}
					c.Value = "-" + sC;
				}
			}
			else if(a.IsMinus() == true && b.IsMinus() == true)
			{
				BigInt a1 = new BigInt();
				BigInt b1 = new BigInt();
				a1.Value = b.ABS();
				b1.Value = a.ABS();
				c = a1 - b1;
			}
			else if(a.IsMinus() == false && b.IsMinus() == true)
			{
				BigInt b1 = new BigInt();
				b1.Value = b.ABS();
				c = a + b1;
			}
			else if(a.IsMinus() == true && b.IsMinus() == false)
			{
				BigInt b1 = new BigInt();
				b1.Value = "-" + b.Value;
				c = a + b1;
			}
			return c;
		}
	}
}
