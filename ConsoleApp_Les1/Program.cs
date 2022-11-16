namespace Lesson_1
{
	class Program
	{
		static void Main()
		{
			string path = "D:/asd1.txt";
			string text = "Программа завершилась, пользователь написал правильный ответ."; 

			Console.WriteLine("Напишите ответ на главный вопрос жизни, вселенной и всего такого.");
			int Anfr = int.Parse(Console.ReadLine());
			if (Anfr == 42)
			{
				Console.WriteLine("Совершенно верно!");
			}
			else
            {
				while (Anfr != 42)
				{ 					
					Console.WriteLine("Всем известно что ответ на гланвый вопрос жизни, вселенной и всего такого - 42");
					Anfr = int.Parse(Console.ReadLine());
				}
				Console.WriteLine("Поздравляю!");
			}
			using (FileStream fstream = new FileStream(path, FileMode.Create))
			{
				using (StreamWriter output = new StreamWriter(fstream))
				{
					output.Write(text);
				}
			}

		}
	}
}