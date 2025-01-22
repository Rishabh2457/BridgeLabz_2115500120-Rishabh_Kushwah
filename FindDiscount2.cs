using System;

class FindDiscount2
	{
		public static void Main(string[] args)
		{
			DiscountedFee();
		}
		
		public static void DiscountedFee()
		{	
			Console.Write("Enter the fee");
			double fee= Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the Discount percent");
			double discountPercent = Convert.ToDouble(Console.ReadLine());
			double payFee = fee - (fee*discountPercent/100);
			Console.WriteLine(string.Format("The discount amount is INR{0} and final discounted fee is INR {1}",fee,payFee));
		}
		
	}