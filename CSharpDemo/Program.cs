using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
	public class Box
	{
		public double len;
		public double wid;
		public double hei;
	}

	class Program
	{
		static void Main(string[] args)
		{
			Box box1 = new Box();
			Box box2 = new Box();

			double V = 0;

			box1.len = 5.0;
			box1.wid = 6.0;
			box1.hei = 7.0;

			//describtion of box2
			box2.len = 10.0;
			box2.wid = 12.0;
			box2.hei = 13.0;

			V = box1.len * box1.wid * box1.hei;
			Console.WriteLine("Box1 V is:{0}", V);

			V = box2.len * box2.wid * box2.hei;
			Console.WriteLine("Box2 V is:{0}", V);
			Console.ReadKey();
		}
	}
}
