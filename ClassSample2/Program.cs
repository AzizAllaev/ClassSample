using System.Text.RegularExpressions;

namespace ClassComparing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person;
			person = new Person();
			Console.Write("Введите имя: ");
			string name = Console.ReadLine();
			person.Name = name;

			Console.Write("Год рождения: ");
			string strigngYear = Console.ReadLine();
			int year = Convert.ToInt32(strigngYear);
			Console.Write("Месяц рождения: ");
			string stringMonth = Console.ReadLine();
			int month = Convert.ToInt32(stringMonth);
			Console.Write("День рождения: ");
			string stringDay = Console.ReadLine();
			int day = Convert.ToInt32(stringDay);
			person.DateOfBirthday = new DateTime(year, month, day);

			Console.WriteLine($"Имя: {person.Name}");
			Console.WriteLine($"Дата рождения: {person.DateOfBirthday}");


			Console.ReadKey();
		}
	}
}

public class Person
{
	private string name;
	private DateTime dateofbirthday;

	public DateTime DateOfBirthday
	{
		set
		{
			dateofbirthday = value;
		}
		get
		{
			return dateofbirthday;
		}
	}
	public string Name
	{
		set
		{
			if (IsOnlyLatter(value))
			{
				name = value;
			}
			else
			{
				Console.WriteLine("Неверный ввод");
			}
		}
		get
		{
			return name;
		}
	}

	bool IsOnlyLatter(string input)
	{
		string pattern = @"^[a-zA-Z\s]+$";
		return Regex.IsMatch(input, pattern);
	}
}
