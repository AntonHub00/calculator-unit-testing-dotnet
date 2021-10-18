using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace unit_testing_calc.Tests
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void TestSumTwoNumbers()
		{
			// Arrange
			Operations op = new Operations();
			double num1 = 7;
			double num2 = 5;
			double expectResult = 12;

			// Act
			double result = op.DoOperation(num1, num2, ValidOperations.add);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestRestTwoNumbers()
		{
			// Arrange
			Operations op = new Operations();
			double num1 = 7;
			double num2 = 5;
			double expectResult = 2;

			// Act
			double result = op.DoOperation(num1, num2, ValidOperations.subtract);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestProductTwoNumbers()
		{
			// Arrange
			Operations op = new Operations();
			double num1 = 7;
			double num2 = 5;
			double expectResult = 35;

			// Act
			double result = op.DoOperation(num1, num2, ValidOperations.multiply);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestDivisionTwoNumbers()
		{
			// Arrange
			Operations op = new Operations();
			double num1 = 7;
			double num2 = 5;
			double expectResult = 1.4;

			// Act
			double result = op.DoOperation(num1, num2, ValidOperations.divide);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestNotValidOperationTwoNumbers()
		{
			// Arrange
			Operations op = new Operations();
			double num1 = 7;
			double num2 = 5;
			double expectResult = 0;

			// Act
			double result = op.DoOperation(num1, num2, (ValidOperations)100);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestSumsWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>() { 1, 2, 3, 4 };
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.add, ValidOperations.add, ValidOperations.add };
			double expectResult = 10;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestSubtractionsWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>() { 1, 2, 3, 4 };
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.subtract, ValidOperations.subtract, ValidOperations.subtract, };
			double expectResult = -8;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestMultiplyWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>() { 1, 2, 3, 4 };
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.multiply, ValidOperations.multiply, ValidOperations.multiply };
			double expectResult = 24;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestDivisionWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>() { 24, 2, 4, 1 };
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.divide, ValidOperations.divide, ValidOperations.divide };
			double expectResult = 3;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(result, expectResult);
		}

		[TestMethod]
		public void TestCombinedOperatorsWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>() { 2, 2, 2, 2, 2 };
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.divide, ValidOperations.add, ValidOperations.subtract, ValidOperations.multiply };
			double expectResult = 2;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(expectResult, result);
		}

		[TestMethod]
		public void TestEmptyNumbersListWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>();
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.divide, ValidOperations.add, ValidOperations.subtract, ValidOperations.multiply };
			double expectResult = 0;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(expectResult, result);
		}

		[TestMethod]
		public void TestSingleNumberListWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>() { 123 };
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.divide, ValidOperations.add, ValidOperations.subtract, ValidOperations.multiply };
			double expectResult = 123;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(expectResult, result);
		}

		[TestMethod]
		public void TestNotEnoughOperatorsWithListOverload()
		{
			// Arrange
			Operations op = new Operations();
			List<double> numbersList = new List<double>() { 123, 1, 5, 2, 1 };
			List<ValidOperations> operationsList = new List<ValidOperations>() { ValidOperations.divide, ValidOperations.add };
			double expectResult = 0;

			// Act
			double result = op.DoOperation(numbersList, operationsList);

			// Assert
			Assert.AreEqual(expectResult, result);
		}
	}
}
