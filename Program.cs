////1 уровень
////4
////Результаты соревнований по прыжкам в высоту определяются по лучшей из двух 
////попыток.Вывести список участников в порядке занятых мест.
////Добавить поле «дисквалификация» и метод, который позволяет дисквалифицировать
////участника. В итоговую таблицу такие участники входить не должны. 

class Spotsmen
{
	private string famile;
	private double attempt1, attempt2;
	public string d { get { return disc; } }
	private string disc;
	private double a;
	public double attempt { get { return a; } }
	public Spotsmen(string f1, double a1, double a2)
	{
		famile = f1;
		attempt1 = a1;
		attempt2 = a2;
		if (attempt1 < attempt2)
		{
			a = attempt2;
		}
		else
		{
			a = attempt1;
		}
	}
	public void print_attempts()
	{
		Console.WriteLine($"famile: {famile}\t rez: {attempt1}, {attempt2}");
	}
	public void Disc()
	{
		if (attempt < 1.50 || attempt > 1.80)
		{
			disc = "yes";
			Console.WriteLine($"famile: {famile}\t дисквалифицирован");
		}
		else
		{
			disc = "no";
			Console.WriteLine($"famile: {famile}\t rez: {attempt}");
		}
	}
	public static void Sort(Spotsmen[] sport)
	{
		int n = sport.Length;
		if (n <= 1)
		{
			return;
		}
		int m = n / 2;
		Spotsmen[] left = new Spotsmen[m];
		Spotsmen[] right = new Spotsmen[n - m];
		for (int i = 0; i < m; i++)
		{
			left[i] = sport[i];
		}
		for (int i = m; i < n; i++)
		{
			right[i - m] = sport[i];
		}
		Sort(left);
		Sort(right);
		MergeSort(sport, left, right);
	}
	public static void MergeSort(Spotsmen[] sport, Spotsmen[] left, Spotsmen[] right)
	{
		int l = 0, r = 0, m = 0;
		while (l < left.Length && r < right.Length)
		{
			if (left[l].attempt >= right[r].attempt)
			{
				sport[m] = left[l];
				l++;
			}
			else
			{
				sport[m] = right[r];
				r++;
			}
			m++;
		}
		while (l < left.Length)
		{
			sport[m] = left[l];
			l++;
			m++;
		}
		while (r < right.Length)
		{
			sport[m] = right[r];
			r++;
			m++;
		}
	}
}
class program
{
	static void Main()
	{
		Spotsmen[] sport = new Spotsmen[5]
		{
		new Spotsmen("sp1", 1.53, 1.67),
		new Spotsmen("sp2", 1.73, 1.37),
		new Spotsmen("sp3", 1.32, 1.14),
		new Spotsmen("sp4", 1.81, 1.65),
		new Spotsmen("sp5", 1.55, 1.56)
		};
		double[] x = new double[5];
		Console.WriteLine("начальная таблица:");
		for (int i = 0; i < 5; i++)
		{
			sport[i].print_attempts();
			x[i] = sport[i].attempt;
		}
		Console.WriteLine();
		Console.WriteLine("промежуточная таблица:");
		for (int i = 0; i < 5; i++)
		{
			sport[i].Disc();
		}
		Console.WriteLine();
		static void Del(Spotsmen[] sport)   //удаление элементов 
		{
			int[] k = new int[5];
			for (int i = 0; i < 5; i++)
			{
				if (sport[i].d == "yes")
				{
					k[i] = i;
				}
			}
			int x = 0;
			for (int i = k[x] + 1; i < 5; i++)
			{
				sport[i - 1] = sport[i];
				if (k[x + 1] != 0)
					x++;
			}
		}
		Spotsmen.Sort(sport);
		Del(sport);
		Console.WriteLine("итоговая таблица:");
		for (int i = 0; i < 5; i++)
		{
			if (sport[i].d != "yes")
				sport[i].Disc();
			else
			{
				break;
			}
		}

	}
}

