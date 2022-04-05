//5) Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
	
public class Task5
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи координату X, (Х!=0): ");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("Введи координату Y, (Y!=0): ");
		int y = int.Parse(Console.ReadLine());
		
		if(x > 0 && y > 0) Console.WriteLine("Первая четверть");
		else if(x < 0 && y > 0) Console.WriteLine("Вторая четверть");
		else if(x < 0 && y < 0) Console.WriteLine("Третья четверть");
		else if(x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
	}
}	

