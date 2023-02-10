// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

bool inWork = true;

while (inWork)
{
    Console.Write("Выбери задачу ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:// палиндром
            {
                Console.WriteLine("Введите пятизначное число");
                int num = int.Parse(Console.ReadLine());
                string array = num.ToString();
                int len = array.Length;
                if (len == 5)
                {
                    if (array[0] == array[4] && array [1] == array[3])
                    {
                        Console.WriteLine($"число {array} является палиндромом");
                    }
                    else 
                    {
                        Console.WriteLine($"число {array} не является палиндромом");
                    }
                }
                else 
                {
                    Console.WriteLine("Не пятизначное число");
                }
                
                break;
            }

			case 2: // 3Д 
            {
                 Console.WriteLine("напишите координаты точки A:");
                Console.Write("X = ");
                int x1 = int.Parse(Console.ReadLine());
                Console.Write("Y = ");
                int y1 = int.Parse(Console.ReadLine());
                Console.Write("Z = ");
                int z1 = int.Parse(Console.ReadLine());

                Console.WriteLine("напишите координаты точки B:");
                Console.Write("X = ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("Y = ");
                int y2 = int.Parse(Console.ReadLine());
                Console.Write("Z = ");
                int z2 = int.Parse(Console.ReadLine());

                double result = (int)(Math.Sqrt( Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2))*100);
                result = result / 100;
                
                Console.WriteLine("Растояние между двумя точками: " + result);
                break;                
            }

            case 3: // кубы
            {
                Console.Write("Число: ");
                int Number = int.Parse(Console.ReadLine());
                int index = 1;
                string result = "";
                
                while (index < Number)
                {
                    result = result + Math.Pow(index, 3) + ", ";
                    index++;
                }

                result = result + Math.Pow(index, 3);
                Console.WriteLine(result);               
                break;
            }

            case -1: inWork = false; break;
        }
    }
}