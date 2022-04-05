//4)  По двум заданным числам проверять является ли одно квадратом другого
	
public class Task4
{
	static void Main(string[] args)
	{
	Console.Write("Введи первое число: ");
	int num1 = Convert.ToInt32(Console.ReadLine());

	Console.Write("Введи второе число: ");
	int num2 = Convert.ToInt32(Console.ReadLine());

	if (num1 == num2 * num2 ) Console.WriteLine(num2 + " является квадратом " + num1);
	else if ( num2 == num1 * num1 )	Console.WriteLine(num1 + " является квадратом " + num2);
	else Console.WriteLine(num2 + " не является квадратом " + num1);
	
	}
}

