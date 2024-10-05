using ClassLibrary;
using System.Text.RegularExpressions;

namespace ClassComparing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Объявление нового объекта.
			Person person;
			person = new Person();

			//-------------------------------------------------------
			Console.Write("Введите имя: ");
			string name = Console.ReadLine();
			person.Name = name;

			/// Важно вводить имя правильно
			/// Иначе если строка будет иметь 
			/// Цифры или любые другие символы
			/// Кроме букв английских то ввод не будет
			/// Осуществлен.
			
			Console.Write("Год рождения: ");
			string strigngYear = Console.ReadLine();

			Console.Write("Месяц рождения: ");
			string stringMonth = Console.ReadLine();

			Console.Write("День рождения: ");
			string stringDay = Console.ReadLine();
			
			

			
			int year = Convert.ToInt32(strigngYear);
			int month = Convert.ToInt32(stringMonth);
			int day = Convert.ToInt32(stringDay);

			/// Конвертируем string в int потому что 
			/// DataTime может работать только с типом int

			person.DateOfBirthday = new DateTime(year, month, day);

			Console.WriteLine($"Имя: {person.Name}");
			Console.WriteLine($"Дата рождения: {person.DateOfBirthday}");


			Console.ReadKey();
		}
	}
}
