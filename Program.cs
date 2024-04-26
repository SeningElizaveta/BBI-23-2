using System.Runtime.CompilerServices;
class programm
{
    abstract class Task
    {
        private string Text;
        public string t { get { return Text; } }
        public Task(string text)
        {
            Text = text;
        }
        private class Task1 : Task
        {
            string Text1;
            public Task1(string text) : base(text)
            {
                Text1 = text;
            }
            public void print1()
            {
                char[] x = Text1.ToCharArray();
                string[] t = Text1.Split(" ");
                string sum = "";
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == ' ' || x[i] >= 'a' && x[i] <= 'z' || x[i] >= 'A' && x[i] <= 'Z' || x[i] >= 'а' && x[i] <= 'я' || x[i] >= 'А' && x[i] <= 'Я')
                    {
                        sum += x[i];
                    }
                    else
                    {
                        sum += "";
                    }
                }
                string[] text1 = sum.Split(" ");
                Console.WriteLine(text1.Length);
            }
        }
        private class Task2 : Task
        {
            string Text1;
            public Task2(string text) : base(text)
            {
                Text1 = text;
            }
            public void print2()
            {
                char[] x = Text1.ToCharArray();
                string[] t = Text1.Split(" ");
                string sum = "";
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == ' ' || x[i] >= 'a' && x[i] <= 'z' || x[i] >= 'A' && x[i] <= 'Z' || x[i] >= 'а' && x[i] <= 'я' || x[i] >= 'А' && x[i] <= 'Я')
                    {
                        sum += x[i];
                    }
                }
                string[] text2 = new string[t.Length];
                for (int i = t.Length-1; i>=0; i--)
                {
                    text2[i]=(t[i]);
                }
                for(int i = 0; i < text2.Length; i++)
                {
                    Console.WriteLine(text2[i]);
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Task1");
            Task1 t1 = new Task1("igrjhi erhgig ikfn frngnr, iig1. FRYokfp phphp thf jvj. ими РВРА Шар, паоРП");
            t1.print1();
            Console.WriteLine();

            Console.WriteLine("Task2");
            Task2 t2 = new Task2("фбв гегм, маоало рпа. ууапе.");
            t2.print2();
            Console.WriteLine();

            Console.WriteLine("Task3");
            string p = @"C:\Users\m2310818\Desktop\m2310818";
            string f = "Solutions";
            p = Path.Combine(p, f);
            if (!Directory.Exists(p))
            {
                Directory.CreateDirectory(p);
            }
            string n1 = "task_1.json";
            string n2 = "task_2.json";
            if (!Directory.Exists(f))
            {
                Directory.CreateDirectory(n1);
            }


        }
    }
}


