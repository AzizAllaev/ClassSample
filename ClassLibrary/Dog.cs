using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
	public class Dog : Animal
	{
		public override void Noise()
		{
			Console.WriteLine("Dog noise 'Bark'");
		}
	}
}