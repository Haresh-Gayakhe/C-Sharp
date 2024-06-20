using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Enter the size of an array: ");
			int size = int.Parse(Console.ReadLine());
			int[] arr = new int[size];
			for (int i = 0; i < size; i++)
			{
                Console.Write("Enter element: ");
				int element = int.Parse(Console.ReadLine());
				arr[i] = element;
            }
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }
	}
}
