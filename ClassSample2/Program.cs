using ClassLibrary;
using System.Text.RegularExpressions;

namespace ClassComparing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dog dog;
			dog = new Dog();
			dog.Noise();
			Cat cat;
			cat = new Cat();
			cat.Noise();

			Console.ReadKey();
		}
	}
}
