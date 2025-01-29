using System;

class Factors
{
	public static void Main(string[] args){
		Console.WriteLine("Enter the number : ");
		int num = int.Parse(Console.ReadLine());
		
		int[] factors = FindFactors(num);
		
		//Console.WriteLine("factors: " + string.Join(", ",factors));
		
		int sum = FindSum(factors);
		int product = FindProduct(factors);
		int sumOfSquare = FindSumOfSquares(factors);
		
		Console.WriteLine("Sum of Factors : " + sum);
		Console.WriteLine("Product of Factors : " + product);
		Console.WriteLine("Sum of Square of factors : " + sumOfSquare);
	
	}
	
	static int[] FindFactors(int num){
		int count = 0;
		//loop for counting the factors
		for(int i =1;i<=num;i++){
			if(num%i==0)
			{
				count++;
			}
		}
		int[] factors = new int[count];
		int index = 0;
		
		//loop for storing factors
		for(int i = 1;i<=num;i++){
			if(num%i==0){
				factors[index] = i;
				index++;
				}
		}
		 return factors;
		}
		
		static int FindSum(int[] factors)
		{
			int sum = 0;
			foreach(int factor in factors){
				sum+= factor;
			}
			return sum;
		}
		
		static int FindProduct(int[] factors)
		{
			int product  = 1;
			foreach(int factor in factors)
			{
				product*= factor;
			}
				return product;
				
		}
		static int FindSumOfSquares(int[] factors)
		{
			int sumOfSquares = 0;
			foreach(int factor in factors){
			sumOfSquares+= (int)Math.Pow(factor,2);
			}
			return sumOfSquares;
			
		}

}		