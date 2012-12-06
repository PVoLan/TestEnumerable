using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace TestEnumerable
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Как ты думаешь, сколько раз будет вызвана функция Do в следующем примере? Cначала попробуй ответить без запуска приложеньки.
			//Погоди, не прокручивай вниз. (представь, что реализация Do тебе неизвестна, например, она лежит в сторонней билиотеке)
			//Известно, что Do возвращает IEnumеrable<int> - числа от 0 до 9
			//
			//Подумал? Теперь запусти

			var list = Do();

			Console.WriteLine("Count: " + list.Count());

			Console.WriteLine("");

			foreach(var item in list)
			{
				Console.WriteLine ("Item: " + item);
			}

			Console.WriteLine("");

			var quadList = list.Select((item) => item*item);
			foreach(var item in quadList)
			{
				Console.WriteLine ("Quad item: " + item);
			}
		}













































































		private static IEnumerable<int> Do()
		{
			Console.WriteLine("Do() called");

			for (int i = 0; i < 10; i++)
			{
				//Console.WriteLine ("Calculating " + i);
				yield return i;
			}

			Console.WriteLine("Do() completed");
		}
	}
}