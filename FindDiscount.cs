using System;

class FindDiscount
	{
		public static void Main(string[] args)
		{
			double fee = 125000;
			double discountPercent = 10;
			DiscountedFee(fee,discountPercent);
		}
		
		public static void DiscountedFee(double fee,double discountPercent)
		{
			double payFee = fee - (fee*discountPercent/100);
			Console.WriteLine(string.Format("The discount amount is INR{0} and final discounted fee is INR {1}",fee,payFee));
		}
		
	}