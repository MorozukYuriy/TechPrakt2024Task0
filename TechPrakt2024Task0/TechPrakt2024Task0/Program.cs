using System.Text;

namespace TechPrakt2024Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Простий калькулятор");

            while (true)
            {
                double number1 = ReadNumber("Введіть перше число: ");
                double number2 = ReadNumber("Введіть друге число: ");

                Console.WriteLine("\nОберіть операцію:");
                Console.WriteLine("1. Додавання (+)");
                Console.WriteLine("2. Віднімання (-)");
                Console.WriteLine("3. Множення (*)");
                Console.WriteLine("4. Ділення (/)");
                Console.WriteLine("5. Вийти");

                Console.Write("Ваш вибір: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    case "+":
                        Console.WriteLine($"Сума: {number1} + {number2} = {number1 + number2}");
                        break;
                    case "2":
                    case "-":
                        Console.WriteLine($"Різниця: {number1} - {number2} = {number1 - number2}");
                        break;
                    case "3":
                    case "*":
                        Console.WriteLine($"Добуток: {number1} * {number2} = {number1 * number2}");
                        break;
                    case "4":
                    case "/":
                        if (number2 != 0)
                            Console.WriteLine($"Частка: {number1} / {number2} = {number1 / number2}");
                        else
                            Console.WriteLine("Помилка: ділення на нуль неможливе.");
                        break;
                    case "5":
                        Console.WriteLine("Вихід з програми.");
                        return;
                    default:
                        Console.WriteLine("Некоректний вибір.");
                        break;
                }

                Console.WriteLine("\n--------------------------------\n");
            }
        }

        static double ReadNumber(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Некоректне значення, спробуйте ще раз.");
                Console.Write(prompt);
            }
            return number;
        }
    }
}
