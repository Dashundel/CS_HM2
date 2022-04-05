//6) Найти расстояние между точками в пространстве 2D/3D
public class Task6
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи пространство (2D или 3D): "); 
		string d = Console.ReadLine();

        int x1, y1, x2, y2;
        double distance;

		switch(d)
		{
		    case "2D":
			    Console.WriteLine("Введи координату Х точки 1: ");
			    x1 = int.Parse(Console.ReadLine());
			
			    Console.WriteLine("Введи координату Y точки 1: ");
			    y1 = int.Parse(Console.ReadLine());	
			
			    Console.WriteLine("Введи координату Х точки 2: ");
			    x2 = int.Parse(Console.ReadLine());
			
			    Console.WriteLine("Введи координату Y точки 2: ");
			    y2 = int.Parse(Console.ReadLine());
	
			    distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); 
			
			    Console.WriteLine("Расстояние: " + distance);
	
            break;	

            case "3D":
			    Console.WriteLine("Введи координату Х точки 1: ");
			    x1 = int.Parse(Console.ReadLine());
			
			    Console.WriteLine("Введи координату Y точки 1: ");
			    y1 = int.Parse(Console.ReadLine());	
			
			    Console.WriteLine("Введи координату Z точки 1: ");
			    int z1 = int.Parse(Console.ReadLine());
			
			    Console.WriteLine("Введи координату Х точки 2: ");
			    x2 = int.Parse(Console.ReadLine());
			
			    Console.WriteLine("Введи координату Y точки 2: ");
			    y2 = int.Parse(Console.ReadLine());
			
			    Console.WriteLine("Введи координату Z точки 2: ");
			    int z2 = int.Parse(Console.ReadLine());
	
			    distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)); 
			
			    Console.WriteLine("Расстояние: " + distance);

            break;	
        default: Console.WriteLine("Вы ввели неверный символ"); 
        break;
        }

	}
}

