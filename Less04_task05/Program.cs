using System;

namespace Less04_task05
{
	interface Interface
	{
		void Method();
	}

	abstract class AbstractClass : Interface
	{
		public abstract void Method();
	}

	class ConcreteClass : AbstractClass
	{
		public override void Method()
		{
			Console.WriteLine("Метод - реализация интерфейса в абстрактном классе.");
		}
	}

	class Program
	{
		static void Main()
		{
			ConcreteClass instance = new ConcreteClass();
			instance.Method();

			Console.ReadKey();
		}
	}
}