using System;
using System.Collections.Generic;
using System.Linq;

namespace unit_testing_calc
{
	public enum ValidOperations
	{
		add,
		subtract,
		multiply,
		divide
	}

	public class Operations
	{
		public double DoOperation(double num1, double num2, ValidOperations operation)
		{
			switch (operation)
			{
				case ValidOperations.add:
					return num1 + num2;
				case ValidOperations.subtract:
					return num1 - num2;
				case ValidOperations.multiply:
					return num1 * num2;
				case ValidOperations.divide:
					return num1 / num2;
				default:
					Console.WriteLine("Not a valid operation");
					return 0;
			}

		}

		public double DoOperation(List<double> numbers, List<ValidOperations> operations)
		{
			if (numbers.Count == 0)
			{
				Console.WriteLine("Not enough numbers to operate");
				return 0;
			}

			if (numbers.Count == 1)
			{
				Console.WriteLine("Not enough numbers to operate");
				return numbers[0];
			}

			// Amount of operations must be at least one less than the amount of numbers
			if ((numbers.Count - operations.Count) > 1)
			{
				Console.WriteLine("Not enough operations to do");
				return 0;
			}

			// Insert the add operation ("+") so the result of first interation
			// in the Aggreate below is the first number itself.
			operations.Insert(0, ValidOperations.add);
			int currentIndex = 0;

			double result = numbers.Aggregate(0.0, (acc, next) =>
			{
				ValidOperations op = operations[currentIndex];
				currentIndex++;
				return this.DoOperation(acc, next, op);
			});


			return result;
		}
	}
}