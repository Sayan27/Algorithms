// C# program to find triplets in a given
// array whose sum is zero
using System;
using System.Collections.Generic;

class GFG
{

	// function to print triplets with 0 sum
	static void findTriplets(int[] arr, int n)
	{
		bool found = false;

		for (int i = 0; i < n - 1; i++)
		{
			// Find all pairs with sum equals to
			// "-arr[i]"
			HashSet<int> s = new HashSet<int>();
			for (int j = i + 1; j < n; j++)
			{
				int x = -(arr[i] + arr[j]);
				if (s.Contains(x))
				{
					Console.Write("{0} {1} {2}\n", x, arr[i], arr[j]);
					found = true;
					Console.ReadLine();
				}
				else
				{
					s.Add(arr[j]);
				}
			}
		}

		if (found == false)
		{
			Console.Write(" No Triplet Found\n");
		}
	}

	// Driver code
	public static void Main(String[] args)
	{
		int[] arr = { 0, -1, 2, -3, 1 };
		int n = arr.Length;
		findTriplets(arr, n);
	}
}

// This code has been contributed by 29AjayKumar
