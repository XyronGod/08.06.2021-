using System;

namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> spisok = new MyList<int>();

			spisok.Add(new Node<int>(90));
			spisok.Add(new Node<int>(20));
			spisok.Add(new Node<int>(30));
			spisok.Add(new Node<int>(40));
			spisok.Add(new Node<int>(50));

			spisok.PushFront(new Node<int>(1));


			Console.WriteLine();
			spisok.Print();
			Console.WriteLine("Первый элемент списка (не считая который мы добавили)");
			Console.WriteLine(spisok.Get(1));
			Console.WriteLine();
			Console.WriteLine();
			spisok.Remove(4);
			spisok.Print();
			Console.WriteLine("Первый элемент списка (не считая который мы добавили)");
			Console.WriteLine(spisok.Get(4));
		}
	}
}

