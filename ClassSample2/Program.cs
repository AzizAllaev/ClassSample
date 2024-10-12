using ClassLibrary;
using System.Text.RegularExpressions;

namespace ClassComparing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Human human1;
			human1 = new Human();

			Console.Write("Введите ФИО: ");
			human1.Name = Console.ReadLine();
			Console.Write("Введите Год рождения: ");
			string stringYear= Console.ReadLine();
			Console.Write("Введите Месяц рождения: ");
			string stringMonth = Console.ReadLine();
			Console.Write("Введите День рождения: ");
			string stringDay = Console.ReadLine();
			Console.Write("Допольнительные параметры(цвет глаз): ");
			string addinfo = Console.ReadLine();
			addinfo = human1.EyeColor;
			int year = Convert.ToInt32(stringYear);
			int month = Convert.ToInt32(stringMonth);
			int day = Convert.ToInt32(stringDay);

			human1.DateOfBirthday = new DateTime(year, month, day);

			Console.WriteLine($"ФИО: {human1.Name} | Дата рождения: {human1.DateOfBirthday}");
			Console.WriteLine(human1.EyeColor);
		}
	}
}
