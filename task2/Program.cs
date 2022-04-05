//2) Показать четные числа от 1 до N
public class Task2
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число: ");
		int n = int.Parse(Console.ReadLine());
			
		for(int i = 1; i < n+1; i++)
		{
			if(i%2 == 0)  Console.WriteLine(i);
        }
			
	}
}

