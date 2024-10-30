using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
	public class Cat : Animal
	{
		public override void Noise()
		{
			Console.WriteLine("Cat noise 'Meow'");
		}
	}
}