using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Smallest_Element
{
	// C# code for kth smallest element
	// in an array
	//using System;

	class GFG
	{

		// Standard partition process of QuickSort.
		// It considers the last element as pivot
		// and moves all smaller element to left of
		// it and greater elements to right
		public static int partition(int[] arr,
									int l, int r)
		{
			int x = arr[r], i = l;
			int temp = 0;
			for (int j = l; j <= r - 1; j++)
			{

				if (arr[j] <= x)
				{
					// Swapping arr[i] and arr[j]
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;

					i++;
				}
			}

			// Swapping arr[i] and arr[r]
			temp = arr[i];
			arr[i] = arr[r];
			arr[r] = temp;

			return i;
		}

		// This function returns k'th smallest
		// element in arr[l..r] using QuickSort
		// based method. ASSUMPTION: ALL ELEMENTS
		// IN ARR[] ARE DISTINCT
		public static int kthSmallest(int[] arr, int l,
									int r, int k)
		{
			// If k is smaller than number
			// of elements in array
			if (k > 0 && k <= r - l + 1)
			{
				// Partition the array around last
				// element and get position of pivot
				// element in sorted array
				int pos = partition(arr, l, r);

				// If position is same as k
				if (pos - l == k - 1)
					return arr[pos];

				// If position is more, recur for
				// left subarray
				if (pos - l > k - 1)
					return kthSmallest(arr, l, pos - 1, k);

				// Else recur for right subarray
				return kthSmallest(arr, pos + 1, r,
								k - pos + l - 1);
			}

			// If k is more than number
			// of elements in array
			return int.MaxValue;
		}

		// Driver Code
		public static void Main()
		{
			int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
			int k = 3;
			Console.Write("K'th smallest element is " + kthSmallest(arr, 0, arr.Length - 1, k));
			Console.ReadLine();
		}
	}

	// This code is contributed
	// by 29AjayKumar

}
