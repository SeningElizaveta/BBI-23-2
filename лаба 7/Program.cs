﻿////1 уровень
////4
////Результаты соревнований по прыжкам в высоту определяются по лучшей из двух 
////попыток.Вывести список участников в порядке занятых мест.
////Добавить поле «дисквалификация» и метод, который позволяет дисквалифицировать
////участника. В итоговую таблицу такие участники входить не должны. 

//class Spotsmen
//{
//	private string famile;
//	private double attempt1, attempt2;
//	public string d { get { return disc; } }
//	private string disc;
//	private double a;
//	public double attempt { get { return a; } }
//	public Spotsmen(string f1, double a1, double a2)
//	{
//		famile = f1;
//		attempt1 = a1;
//		attempt2 = a2;
//		if (attempt1 < attempt2)
//		{
//			a = attempt2;
//		}
//		else
//		{
//			a = attempt1;
//		}
//	}
//	public void print_attempts()
//	{
//		Console.WriteLine($"famile: {famile}\t rez: {attempt1}, {attempt2}");
//	}
//	public void Disc()
//	{
//		if (attempt < 1.50 || attempt > 1.80)
//		{
//			disc = "yes";
//			Console.WriteLine($"famile: {famile}\t дисквалифицирован");
//		}
//		else
//		{
//			disc = "no";
//			Console.WriteLine($"famile: {famile}\t rez: {attempt}");
//		}
//	}
//}
//class program
//{
//	static void Main()
//	{
//		Spotsmen[] sport = new Spotsmen[5]
//		{
//		new Spotsmen("sp1", 1.53, 1.67),
//		new Spotsmen("sp2", 1.73, 1.37),
//		new Spotsmen("sp3", 1.32, 1.14),
//		new Spotsmen("sp4", 1.81, 1.65),
//		new Spotsmen("sp5", 1.55, 1.56)
//		};
//		double[] x = new double[5];
//		Console.WriteLine("начальная таблица:");
//		for (int i = 0; i < 5; i++)
//		{
//			sport[i].print_attempts();
//			x[i] = sport[i].attempt;
//		}
//		Console.WriteLine();
//		Console.WriteLine("промежуточная таблица:");
//		for (int i = 0; i < 5; i++)
//		{
//			sport[i].Disc();
//		}
//		Console.WriteLine();
//		Sort(x, sport);
//		Del(sport);
//		Console.WriteLine("итоговая таблица:");
//		for (int i = 0; i < 5; i++)
//		{
//			if (sport[i].d != "yes")
//				sport[i].Disc();
//			else
//			{
//				break;
//			}
//		}
//		static void Del(Spotsmen[] sport)   //удаление элементов 
//		{
//			int[] k = new int[5];
//			for (int i = 0; i < 5; i++)
//			{
//				if (sport[i].d == "yes")
//				{
//					k[i] = i;
//				}
//			}
//			int x = 0;
//			for (int i = k[x] + 1; i < 5; i++)
//			{
//				sport[i - 1] = sport[i];
//				if (k[x + 1] != 0)
//					x++;
//			}
//		}
//		static void Sort(double[] x, Spotsmen[] sport)
//		{
//			int n = 5;
//			for (int i = 0; i < n; i++)
//			{
//				for (int j = 0; j < n - 1; j++)
//				{
//					if (x[j] < x[j + 1])
//					{
//						(sport[j + 1], sport[j]) = (sport[j], sport[j + 1]);
//						(x[j + 1], x[j]) = (x[j], x[j + 1]);
//					}
//				}
//			}
//		}
//	}

//}









////2 уровень
////1
////Студенты одной группы в сессию сдают четыре экзамена. Составить список 
////студентов, средний балл которых по всем экзаменам не менее «4». Результаты 
////вывести в виде таблицы с заголовком в порядке убывания среднего балла.

////Сделать класс «Человек». Класс студент должен наследоваться от него
////и иметь дополнительное поле «номер студ. билета».
////При выводе в таблице должны быть ФИО, номер студ. билета и средний балл.


//class program
//{
//	abstract class human
//	{
//		private string famile;
//		private double mark;
//		public double m { get { return mark; } }
//		public human(string f, int mark1, int mark2, int mark3, int mark4)
//		{
//			famile = f;
//			mark = (double)(mark1 + mark2 + mark3 + mark4) / 4;
//		}
//		public virtual void print()
//		{
//			Console.Write($"фамилия {famile}\t балл {mark}");
//		}

//	}
//	private class student : human
//	{
//		private static Random random = new Random();
//		private int stud = random.Next(100, 150);
//		private int nomer_stud;
//		public student(string f, int mark1, int mark2, int mark3, int mark4) : base(f, mark1, mark2, mark3, mark4)
//		{
//			nomer_stud = stud;
//		}
//		public override void print()
//		{
//			base.print();
//			Console.Write($"  \tстуденческий: {nomer_stud}");
//			Console.WriteLine();
//		}
//	}
//	static void Main()
//	{
//		student[] st = new student[5];
//		st[0] = new student("студент1", 5, 5, 2, 5);
//		st[1] = new student("студент2", 5, 4, 5, 5);
//		st[2] = new student("студент3", 3, 2, 3, 4);
//		st[3] = new student("студент4", 4, 2, 5, 5);
//		st[4] = new student("студент5", 3, 5, 4, 3);
//		double[] x = new double[5];
//		for (int i = 0; i < st.Length; i++)
//		{
//			st[i].print();
//			x[i] = st[i].m;
//		}
//		Sort(x, st);
//		static void Sort(double[] x, student[] st)
//		{
//			for (int i = 0; i < st.Length; i++)
//			{
//				for (int j = 0; j < st.Length - 1; j++)
//				{
//					if (x[j] < x[j + 1])
//					{
//						(st[j], st[j + 1]) = (st[j + 1], st[j]);
//						(x[j], x[j + 1]) = (x[j + 1], x[j]);
//					}
//				}
//			}
//		}
//		Console.WriteLine();
//		for (int i = 0; i < st.Length; i++)
//		{
//			if (st[i].m >= 4)
//			{
//				st[i].print();
//			}
//			else break;
//		}
//	}
//}










////3 уровень
////1
////Результаты сессии содержат оценки 5 экзаменов по каждой группе. Определить 
////средний балл для трех групп студентов одного потока и выдать список групп в 
////порядке убывания среднего бала. Результаты вывести в виде таблицы с заголовком.

////Создать класс «Группа» с набором общих для всех групп-наследников предметов (3-4)
////и от него 3 наследника (названия групп) с дополнительными 2 различными предметами.
////В наследниках переопределить метод расчета среднего балла за сессию.
////Вывести студентов всех групп единым списком.
////Использовать динамическую связку: преобразование классов.

//class programm
//{
//	abstract class Group
//	{
//		private string group;
//		private string famile;
//		private double mark;
//		private double math, physics, english;
//		public double m { get { return mark; } }
//		public Group(string g, string f, int mark1, int mark2, int mark3)
//		{
//			group = g;
//			famile = f;
//			mark = (double)(mark1 + mark2 + mark3) / 3; //средний балл за 3
//		}
//		public virtual void print()
//		{
//			Console.WriteLine($"группа: {group}, фамилия: {famile}\t средний балл по 3 экзаменам: {mark}");
//		}
//	}
//	private class Group1 : Group
//	{
//		private double biology, chemistry;
//		private double mark_group1;
//		public double m { get { return mark_group1; } }
//		public Group1(string g, string f, int mark1, int mark2, int mark3, int mark4, int mark5) : base(g, f, mark1, mark2, mark3)
//		{
//			biology = mark4;
//			chemistry = mark5;
//			mark_group1 = (double)(mark1 + mark2 + mark3 + mark4 + mark5) / 5; //средний балл за 5
//		}
//		public override void print()
//		{
//			base.print();
//		}
//		public void print1()
//		{
//			Console.WriteLine(mark_group1);
//		}
//	}
//	private class Group2 : Group
//	{
//		private double history, geography;
//		private double mark_group2;
//		public double m { get { return mark_group2; } }
//		public Group2(string g, string f, int mark1, int mark2, int mark3, int mark4, int mark5) : base(g, f, mark1, mark2, mark3)
//		{
//			history = mark4;
//			geography = mark5;
//			mark_group2 = (double)(mark1 + mark2 + mark3 + mark4 + mark5) / 5; //средний балл за 5
//		}
//		public override void print()
//		{
//			base.print();
//		}
//		public void print2()
//		{
//			Console.WriteLine(mark_group2);
//		}
//	}
//	private class Group3 : Group
//	{
//		private double programming, art;
//		private double mark_group3;
//		public double m { get { return mark_group3; } }
//		public Group3(string g, string f, int mark1, int mark2, int mark3, int mark4, int mark5) : base(g, f, mark1, mark2, mark3)
//		{
//			programming = mark4;
//			art = mark5;
//			mark_group3 = (double)(mark1 + mark2 + mark3 + mark4 + mark5) / 5; //средний балл за 5
//		}
//		public override void print()
//		{
//			base.print();
//		}
//		public void print3()
//		{
//			Console.WriteLine(mark_group3);
//		}
//	}
//	static void Main()
//	{
//		Group1[] st1 = new Group1[3];
//		st1[0] = new Group1("group1", "student1", 2, 4, 2, 5, 4);
//		st1[1] = new Group1("group1", "student2", 3, 2, 2, 5, 5);
//		st1[2] = new Group1("group1", "student3", 4, 5, 5, 4, 5);
//		Group2[] st2 = new Group2[3];
//		st2[0] = new Group2("group2", "student4", 2, 4, 3, 5, 3);
//		st2[1] = new Group2("group2", "student5", 3, 3, 4, 5, 2);
//		st2[2] = new Group2("group2", "student6", 4, 5, 5, 4, 5);
//		Group3[] st3 = new Group3[3];
//		st3[0] = new Group3("group3", "student7", 2, 5, 3, 5, 3);
//		st3[1] = new Group3("group3", "student8", 4, 5, 5, 4, 5);
//		st3[2] = new Group3("group3", "student9", 5, 5, 5, 2, 2);
//		double[] group1 = new double[3];
//		double[] group2 = new double[3];
//		double[] group3 = new double[3];
//		Console.WriteLine("GROUP 1:");
//		for (int i = 0; i < 3; i++)
//		{
//			st1[i].print();
//			Console.WriteLine($"средний балл по 5 экзаменам: {st1[i].m}");
//			group1[i] = st1[i].m;
//		}
//		Console.WriteLine();
//		Console.WriteLine("GROUP 2:");
//		for (int i = 0; i < 3; i++)
//		{
//			st2[i].print();
//			Console.WriteLine($"средний балл по 5 экзаменам: {st2[i].m}");
//			group2[i] = st2[i].m;
//		}
//		Console.WriteLine();
//		Console.WriteLine("GROUP 3:");
//		for (int i = 0; i < 3; i++)
//		{
//			st3[i].print();
//			Console.WriteLine($"средний балл по 5 экзаменам: {st3[i].m}");
//			group3[i] = st3[i].m;
//		}
//		Console.WriteLine();
//		Sort(group1, st1);
//		Sort(group2, st2);
//		Sort(group3, st3);
//		Console.WriteLine("отсортировано по 5 экзаменам:");
//		Console.WriteLine();
//		Console.WriteLine("GROUP 1:");
//		for (int i = 0; i < 3; i++)
//		{
//			st1[i].print();
//			Console.WriteLine($"средний балл по 5 экзаменам: {st1[i].m}");
//		}
//		Console.WriteLine();
//		Console.WriteLine("GROUP 2:");
//		for (int i = 0; i < 3; i++)
//		{
//			st2[i].print();
//			Console.WriteLine($"средний балл по 5 экзаменам: {st2[i].m}");
//		}
//		Console.WriteLine();
//		Console.WriteLine("GROUP 3:");
//		for (int i = 0; i < 3; i++)
//		{
//			st3[i].print();
//			Console.WriteLine($"средний балл по 5 экзаменам: {st3[i].m}");
//		}
//		Console.WriteLine();
//		static void Sort(double[] mark_st, Group[] st)
//		{
//			for (int i = 0; i < 3; i++)
//			{
//				for (int j = 0; j < 3 - 1; j++)
//				{
//					if (mark_st[j] < mark_st[j + 1])
//					{
//						(mark_st[j], mark_st[j + 1]) = (mark_st[j + 1], mark_st[j]);
//						(st[j + 1], st[j]) = (st[j], st[j + 1]);
//					}
//				}
//			}
//		}
//	}
//}
