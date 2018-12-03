/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 03/12/2018
 * Time: 1:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOP01
{
	/// <summary>
	/// Description of Cat.
	/// </summary>
	public class Cat: Animal
	{
		public int Age;
		public int Height;
		public Cat():base()
		{
			Age = 0;
			Height = 0;
		}
		public Cat( string sName, int iAge, int iHeight):base()
		{
			Age = iAge;
			Height = iHeight;
		}
		public void Say()
        {
            Console.WriteLine("Meo");
        }
		public override string ToString()
		{
			return string.Format("Class:Cat;Name:{0};Age:{1};Height:{2}", Name, Age, Height);
		}
		public override void Move()
		{
			Console.WriteLine("Cat move");
		}
		public void Sleep()
		{
			
		}
	}
}
