//3) Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введи номер дня недели: ");
	int num_day = Convert.ToInt32(Console.ReadLine());
	switch(num_day)
	{
		case 1:
			Console.Write("”Понедельник - не выходной");
			break;
		case 2:
			Console.Write("Вторник - не выходной ");
			break;
		case 3:
			Console.Write("Среда - не выходной ");
			break;
		case 4:
			Console.Write("Четверг - не выходной ");
			break;
		case 5:
			Console.Write("Пятница - не выходной ");
			break;
		case 6:
			Console.Write("Суббота - выходной ");
			break;
		case 7:
			Console.Write("Воскресенье - выходной");
			break;	
		default:
			Console.Write("Неверное число ");
			break;
	
	}
