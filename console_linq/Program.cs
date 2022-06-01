// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 2, 3, 4, 5 };
int[] numbersRange = Enumerable.Range(1, 20).ToArray();

//Methods Syntax or Lambda Sintax
var pairNumbers = numbers.Where(n => n % 2 == 0).ToList();

//Queries syntax
var pairNumbers2 = from n in numbers
                   where n % 2 == 0
                   select n;

//Range
var pairRangeNumbers = numbersRange.Where(n => n % 2 == 0).ToList();

Console.WriteLine("Hello, World!");
