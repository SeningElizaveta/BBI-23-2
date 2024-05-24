﻿class Program
{

	abstract class Task
	{
		private string Text;
		public string t { get { return Text; } }
		public Task(string text)
		{
			Text = text;
		}
	}
	private class Task1 : Task
	{
		string Text;
		public Task1(string text) : base(text)
		{
			Text = text;
		}
		public void print1()
		{
			char[] x = new char[33];
			int[] chast = new int[33]; //массив с частотой букв
			char[] Text1 = Text.ToCharArray();
			for (int i = 0; i < 33; i++)
			{
				int ch = Text1.Count(l => l == "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"[i]); //подсчёт частоты каждой буквы
				chast[i] = ch; //присваивание массиву частоту
				x[i] = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"[i];
			}
			for (int i = 0; i < 33; i++)
			{
				double chastota = (double)chast[i] / Text.Length;
				Console.WriteLine($"буква {x[i]} встречается {chastota}");
			}
		}
	}
	private class Task3 : Task
	{
		string Text;
		public Task3(string text) : base(text)
		{
			Text = text;
		}
		public void print3()
		{
			int lenght = 0; //длина строки
			string text3 = ""; //слова в строке
			string[] Text3 = Text.Split(' '); //текст пословно
			foreach (string s in Text3)
			{
				if (lenght + s.Length <= 50)
				{
					lenght += s.Length + 1;
					text3 += s + " ";
				}
				else
				{
					Console.WriteLine(text3);
					text3 = s + " ";
					lenght = s.Length + 1;
				}
			}
			Console.WriteLine(text3);
		}
	}
	private class Task5 : Task
	{
		string Text;
		public Task5(string text) : base(text)
		{
			Text = text;
		}
		public void print5()
		{
			Text = Text.ToLower(); //нижний регистр
			int[] chast = new int[33]; //массив с частотой начальных букв
			char[] t = new char[Text.Length]; //начальные буквы
			string[] Text5 = Text.Split(' '); //текст пословно
			for (int i = 0; i < Text5.Length; i++)
			{
				t[i] = Text5[i][0]; //начальные буквы
			}
			t.ToString();
			for (int i = 0; i < 33; i++)
			{
				int ch = t.Count(l => l == "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"[i]); //подсчёт частоты каждой буквы
				chast[i] = ch; //присваивание массиву частоту
			}
			int[,] text = new int[33, 2];
			for (int i = 0; i < 33; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					text[i, 0] = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"[i]; //буква
					text[i, 1] = chast[i]; //её частота
				}
			}
			for (int i = 0; i < 33 - 1; i++)
			{
				for (int j = 0; j < 33 - 1 - i; j++)
				{
					if (text[j, 1] < text[j + 1, 1])
					{
						for (int k = 0; k < 2; k++)
						{
							(text[j, k], text[j + 1, k]) = (text[j + 1, k], text[j, k]);
						}
					}
				}
			}
			int[] bukva = new int[33];
			int[] chastota = new int[33];
			for (int i = 0; i < 33; i++)
			{
				{
					bukva[i] = (char)text[i, 0];// + 97;
					chastota[i] = text[i, 1];
				}
			}
			for (int i = 0; i < 33; i++)
			{
				if (chastota[i] != 0)
				{
					Console.WriteLine($"буква {(char)bukva[i]}, частота {chastota[i]}");
				}
				else
				{
					break;
				}
			}
		}
	}
	private class Task7 : Task
	{
		string Text;
		public Task7(string text) : base(text)
		{
			Text = text;
		}
		public void print7()
		{
			string Text1 = Text.ToLower(); //нижний регистр
			string[] text71 = Text1.Split(" "); //текст пословно
			string[] text7 = Text.Split(" "); //сюда изначальный текст без перевода в нижний регистр
			string posledovatelnost = "пут";
			for (int i = 0; i < text71.Length; i++)
			{
				if (text71[i][0] == posledovatelnost[0] && text71[i][1] == posledovatelnost[1] && text71[i][2] == posledovatelnost[2])
				{
					Console.WriteLine(text7[i]);
				}
			}
		}
	}
	private class Task11 : Task
	{
		string Text;
		public Task11(string text) : base(text)
		{
			Text = text;
		}
		public void print11()
		{
			string[] text11 = Text.Split(", ");
			for (int i = 0; i < text11.Length; i++)
			{
				int x = 0;
				for (int j = 0; j < text11.Length - 1; j++)
				{
					if (text11[j][0] > text11[j + 1][0])
					{
						(text11[j], text11[j + 1]) = (text11[j + 1], text11[j]);
					}
				}
			}
			for (int i = 0; i < text11.Length; i++)
			{
				for (int j = 0; j < text11.Length - 1; j++)
				{
					if (text11[j][0] >= text11[j + 1][0] && text11[j][1] > text11[j + 1][1])
					{
						(text11[j], text11[j + 1]) = (text11[j + 1], text11[j]);
					}
				}
			}
			for (int i = 0; i < text11.Length; i++)
			{
				Console.WriteLine(text11[i]);
			}
		}
	}
	private class Task14 : Task
	{
		string Text;
		public Task14(string text) : base(text)
		{
			Text = text;
		}
		public void print14()
		{
			int sum = 0;
			string summ = "";
			char[] chars = Text.ToCharArray();
			string[] text11 = Text.Split(' ', '.', ',', '!', '?', ':', ';');
			foreach (char ch in chars)
			{
				if (ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
				{
					summ += ch.ToString();
				}
			}
			for (int i = 0; i < chars.Length - 1; i++)
			{
				if (chars[i] == '1' & chars[i + 1] == '0')
				{
					summ += "10";
				}
				if (chars[i] == '1' & chars[i + 1] != '0')
				{
					summ += "1";
				}
			}
			string a = summ.ToString();
			string[] x = new string[a.Length];
			for (int i = 0; i < summ.Length - 1; i++)
			{
				if (summ[i] == '1' & summ[i + 1] == '0')
				{
					x[i] = "10";
				}
				else if (summ[i] == '1' & summ[i + 1] != '0')
				{
					x[i] = "1";
				}
				else
				{
					x[i] = a[i].ToString();
				}
			}
			for (int i = 0; i < summ.Length; i++)
			{
				if (x[i] != null)
				{
					sum += int.Parse(x[i]);
				}
			}
			Console.WriteLine(sum);
		}
	}

	static void Main()
	{
		Console.WriteLine("Task1");
		Task1 t1 = new Task1("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");

		//Task1 t1 = new Task1("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
		t1.print1();
		Console.WriteLine();

		Console.WriteLine("Task3");
		Task3 t3 = new Task3("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
		t3.print3();
		Console.WriteLine();

		Console.WriteLine("Task5");
		Task5 t5 = new Task5("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
		t5.print5();
		Console.WriteLine();

		Console.WriteLine("Task7");
		Task7 t7 = new Task7("Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.");
		t7.print7();
		Console.WriteLine();

		Console.WriteLine("Task11");
		Task11 t11 = new Task11("Иванов, Петров, Смирнов, Соколов, Кузнецов, Попов, Лебедев, Волков, Козлов, Новиков, Иванова, Петрова, Смирнова, Ivanov, Petrov, Smirnov, Sokolov, Kuznetsov, Popov, Lebedev, Volkov, Kozlov, Novikov, Ivanova, Petrova, Smirnova");
		t11.print11();
		Console.WriteLine();

		Console.WriteLine("Task14");
		Task14 t14 = new Task14("Перв4ое кругосветное путешествие было осуществлено флотом, " +
			"возглавляемым португальским исследователем Фе3рнаном Магелланом. " +
			"Путешестви3е началось сентября года, когда флот, состоящий из пяти кораблей и примерно человек," +
			" от1правился из пор10ту Сан-Лукас в Испании. " +
			"Хо6тя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в году," +
			" его экспедиция с7тала первой, которая успе1шно обогнула Землю и доказала ее круглую форму." +
			" Это 10путешествие открыло новые морские пути и имело огромное значение для картографии и 4-е географических открытий."); //49
		t14.print14();
		Console.WriteLine();
	}
}