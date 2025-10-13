using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public abstract class Animal
	{
		private string _Name;

		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
			}
		}

		public virtual void Noise()
		{
			Console.WriteLine("Animal do noise");
		}
	}
}
