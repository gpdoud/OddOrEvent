using System;

namespace OddOrEvent
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nbrs2 = { 3023, 8760, 1112, 8232, 8107 };
			#region code
			var largest = 0;
			var smallest = 9999;
			var sum = 0;

			foreach(var n in nbrs2)
			{
				if (n > largest) largest = n;
				if (n < smallest) smallest = n;
				sum = sum + n;
			}

			var max = sum - smallest;
			var min = sum - largest;
			#endregion

			Console.WriteLine($"Largest is {max}, smallest is {min}");















			//int[] nbrs = {
			//   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
			//   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
			//   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
			//   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
			//   435, 643, 809, 874, 906, 620, 328, 369, 426, 561
			//};

			//var highest = int.MinValue;
			//var lowest = int.MaxValue;

			//foreach(var nbr in nbrs)
			//{
			//	if(nbr > highest)
			//	{
			//		highest = nbr;
			//	}
			//	if(nbr < lowest)
			//	{
			//		lowest = nbr;
			//	}
			//}
			//Console.WriteLine($"Highest is {highest}, lowest is {lowest}");












			//var total = 0;
			//for(var idx = 1; idx <= 50; idx++)
			//{
			//	if(idx % 5 == 0)
			//	{
			//		total = total + idx;
			//		continue;
			//	}
			//	if (idx % 7 == 0)
			//	{
			//		total = total + idx;
			//	}
			//}
			//Console.WriteLine($"Total is {total}");

			//var comma = "";
			//for (int idx = 1; idx <= 25; idx++)
			//{
			//	Console.Write($"{comma} {idx}");
			//	comma = ",";
			//}

			//for(var idx = 0; idx < 5; idx++)
			//{
			//	Console.Write("Enter an integer: ");
			//	var answer = Console.ReadLine();
			//	var value = Convert.ToInt32(answer);

			//	if(value % 2 == 0)
			//	{
			//		Console.WriteLine("The number is even");
			//	} else
			//	{
			//		Console.WriteLine("The number is odd");
			//	}

			//}

		}
	}
}
