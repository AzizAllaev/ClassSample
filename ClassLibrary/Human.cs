using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
	/// <summary>
	/// Класс Human является обстракцией человека
	/// То есть персона имеет 2 свойства это имя и 
	/// Дата рождения.
	/// А этот класс допольнительно имеет имя своих
	/// у кого унаследовал и behavour 
	/// </summary>
	public class Human : Person
	{
		private string _Behaviour;

		public Human()
		{
			protectedFieldParentsName = "Унаследован от Person";
		}

		public string EyeColor
		{
			get
			{
				return _Behaviour;
			}
			set
			{
				_Behaviour = value;
			}
		}
		
	}
}