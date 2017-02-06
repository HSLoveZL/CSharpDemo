using System;

class Rectangle
{
	protected double length;
	protected double width;

	public Rectangle(double l, double w)
	{
		length = l;
		width = w;
	}

	public double GetArea()
	{
		return length * width;
	}

	public void Display()
	{
		Console.WriteLine("长度为:{0}", length);
		Console.WriteLine("宽度为:{0}", width);
		Console.WriteLine("面积为:{0}", GetArea());
	}
}

class Tabletop : Rectangle
{
	private double cost;

	public Tabletop(double l, double w) : base(l, w)
	{}

	public double GetCost()
	{
		double cost;
		cost = GetArea() * 70;
		return cost;
	}

	public void Display()
	{
		base.Display();
		Console.WriteLine("成本为:{0}", GetCost());
	}
}

class RectangleTest
{
	public static void Main(string[] args)
	{
		Tabletop t = new Tabletop(4.5, 7.5);
		t.Display();
		Console.ReadLine();
	}
}