using System;
using System.Threading.Tasks;

namespace FrameworkBenchmark.NetCore22.Helpers
{
	public static class Fibonacci
	{
		public static int GetFibonacciNumberByIndex(int index)
		{
			if (index < 0)
			{
				throw new Exception("Index must be a positive value!");
			}
			
			if (index == 0)
			{
				return 0;
			}
			
			int[] fibonaccies = new int[index + 1];  
			fibonaccies[0]= 0;  
			fibonaccies[1]= 1;
			
			for (int i = 2; i <= index; i++)
				fibonaccies[i] = fibonaccies[i - 2] + fibonaccies[i - 1];
			
			return fibonaccies[index]; 
		}

		public static async Task<int> GetFibonacciNumberByIndexAsync(int index)
		{
			return await Task.Run(() => GetFibonacciNumberByIndex(index));
		}
	}
}