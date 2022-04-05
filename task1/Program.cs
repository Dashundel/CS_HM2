//1) Показать числа от -N до N

using System;
public class Task1
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число: ");
		int n = int.Parse(Console.ReadLine());
			
		for(int i = -n; i < n+1; i++)
		{
            Console.WriteLine(i);
        }	
	}
}

