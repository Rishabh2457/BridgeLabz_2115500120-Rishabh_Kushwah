using System;

class ProfitCal{
	public static void Main(string[] args)
	{
		double cP = 129;
		double sP = 191;
		CalculateProfit(cP,sP);
		
	}
	//methode to calculate profit and profit percentage
	public static void CalculateProfit(double cP,double sP){
		double profit = sP-cP;
		double profitPer = (profit/cP)*100;
		Console.WriteLine(string.Format("The Cost Price is INR {0} and Selling Price is INR {1}\nThe Profit is INR {2} and the Profit Percentage is {3}",cP,sP,profit,profitPer));
		}
	}

	