using System.Text.RegularExpressions;

namespace ClassLibrary
{
	/// <summary>
	/// Person представляет собой обстракцию персоны
	/// Которая имеет дату рождения и имя(полное т.е ФИО)
	/// </summary>
	public class Person
	{
		// Два свойства класса Person имя(ФИО) и дата рождения
		
		private string name;
		private DateTime dateofbirthday;

		//------------------------------------------------------

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

		//------------------------------------------------------
		
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
		
		//-----------------------------------------------------------------------------
		
		/// <summary>
		/// А метод IsOnlyLatter осуществляет проверку строки
		/// На наличие цифр и любых других символов кроме 
		/// Английских букв
		/// </summary>
		
		//-----------------------------------------------------------------------------
		
		bool IsOnlyLatter(string input)
		{
			string pattern = @"^[a-zA-Z\s]+$";
			return Regex.IsMatch(input, pattern);
		}
	}
}
