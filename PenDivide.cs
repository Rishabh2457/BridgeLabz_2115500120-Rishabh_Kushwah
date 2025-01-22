using System;

class  PenDivide
{
	public static void Main(string[] args)
	{
		int totalPen = 14;
		int student = 3;
		CalculatePenDivision(totalPen,student);
		
	}
	//methode to find pen division and remaining student
	public static void CalculatePenDivision(int totalPen,int student)
	{
		int penQuantity = totalPen/student;
		int studentRemaining = totalPen%student;
		Console.WriteLine(string.Format("The Pen Per Student is {0} and the remaining pen not distributed is {1}",penQuantity,studentRemaining));
	}
	
}
		
		
		
		
		
		
		

		