/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/12/2018
 * Time: 1:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of Animal.
	/// </summary>
	public class Animal
	{
		public string Name;
		public Animal()
		{
			Name = "Animal";
		}
		public Animal(string sName)
		{
			Name = sName;
		}
		public override string ToString()
		{
			return string.Format("Name:{0}",Name);
		}
		public virtual void Move()
		{
			Console.WriteLine("{0} move", Name);
		}
		public void Sleep()
		{
			Console.WriteLine("{0} sleep", Name);
		}
	}
}
