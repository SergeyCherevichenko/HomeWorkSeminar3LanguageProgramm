using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HomeWorkSeminar3;
class Program
{
    static void Main(string[] args)
    {
        void task19()
        {
            //Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            //14212 -> нет
            //12821 -> да
            //23432 -> да
            int Input()
            {
                Console.WriteLine("Ведите целое пятизначное число: ");
                bool num = false;
                int number = 0;
                while (!num)
                {
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        num = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Вы ввели не целое число?");
                        task19();

                    }
                }
                return number;
            }

            int userNumber = Input();
            int count = 1;
            bool palindrom = true;
            int result = userNumber;


            while (userNumber > 10)
            {
                userNumber = userNumber / 10;
                count++;
            }
            while (count != 5)
            {
                Console.WriteLine("Вы ввели не пятизначное целое число!");

                task19();
            }
            int reverse = 0;
            int div = 0;
            int num = result;

            while (result > 0)
            {
                div = result % 10;
                reverse = reverse * 10 + div;
                result = result / 10;
            }
            if (num == reverse) palindrom = true;
            else palindrom = false;

            Console.WriteLine(reverse);

            Console.WriteLine($"Ваше число {num} являяется полиндромом! Ответ: {palindrom}");
        }

        void task21()
        {
            //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            //A (3,6,8); B (2,1,-7), -> 15.84
            //A (7,-5, 0); B (1,-1,9) -> 11.53

            double Input(string text)
            {
                Console.Write(text);
                double coordinate = Convert.ToDouble(Console.ReadLine());
                return coordinate;

            }
            double pixelAx = Input("Введите координату первой точки. X = ");
            double pixelAy = Input("Введите координату первой точки. Y = ");
            double pixelAz = Input("Введите координату первой точки. Z = ");
            double pixelBx = Input("Введите координату второй точки. X = ");
            double pixelBy = Input("Введите координату второй точки. Y = ");
            double pixelBz = Input("Введите координату второй точки. Z = ");


            double distanceAB = Math.Sqrt(Math.Pow((pixelBx - pixelAx), 2) + Math.Pow((pixelBy - pixelAy), 2) + Math.Pow((pixelBz - pixelAz), 2));
            double result = Math.Round(distanceAB, 2);
            Console.WriteLine($"Расстояние между вашими точками A ({pixelAx}, {pixelAy}, {pixelAz}) и B ({pixelBx}, {pixelBy}, {pixelBz}) равно {result}");
        }

        void task23()
        {
            //Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            //3 -> 1, 8, 27
            //5 -> 1, 8, 27, 64, 125
            Console.WriteLine("Ведите целое число таблицу кубов которого вы хотите получить: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (number >= i)
            {
                Console.WriteLine(i + " ^ " + "3 " + " = " + Math.Pow(i, 3) + " ");
                i++;
            }

        }

        void task1()
        {
            // Задача 1. Рассчитать значение y при заданном x по формуле

            Console.Write("Введите число X = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x > 0) y = Math.Pow(Math.Sin(x), 2);
            else y = 1 - 2 * Math.Sin(Math.Pow(x, 2));

            Console.WriteLine($"Вычисляем по формуле Y = {y}");

        }

        void task2()
        {
            //Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.

            Console.WriteLine("Введите трехзначное целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int userNumber = number;
            while (number > 1)
            {
                sum = sum + number % 10;
                count++;
                number = number / 10;

            }
            if (count != 3) Console.WriteLine("Вы ввели не трехзначное число");
            else Console.WriteLine($"Сумма всех цифр вашего числа {userNumber} = {sum}");


        }

        void task3()
        {
            // Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.

            Console.WriteLine("Введите трехзначное целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int userNumber = number;
            int count = 0;
            int digit = 0;
            bool digit4or7 = false;
            while (number > 1)
            {
                digit = number % 10;
                if (digit == 4 || digit == 7) digit4or7 = true;
                count++;
                number = number / 10;

            }
            if (count != 3) Console.WriteLine("Вы ввели не трехзначное число");
            else Console.WriteLine($" В вашем числе {userNumber} есть цифра 4 или 7? Ответ: {digit4or7}");

        }

        void task4()
        {
            // Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            Console.WriteLine("Массив заполнен!");
            Array.ForEach(array, Console.WriteLine);

        }

        void task5()
        {
            // Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. Определите самый оптимальный 
            //маршрут для торгового менеджера, который выезжает из центра координат.
            Random random = new Random();

            int[] Point(int number1, int number2, int number3, int number4)
            {
                int[] PointsCoordinats = new int[6];
                int i = 0;
                while (i < 6)
                {
                    PointsCoordinats[i] = random.Next(number1, number2);
                    PointsCoordinats[i + 1] = random.Next(number3, number4);
                    i += 2;
                }
                return PointsCoordinats;
            }

            void Distanse(int[] array)
            {
                string str = "Оптимальный маршрут для торгового менеджера из точки O(0,0) до точки ";
                double distanceOA = Math.Sqrt(Math.Pow(array[0], 2) + Math.Pow(array[1], 2));
                double distanceOB = Math.Sqrt(Math.Pow(array[2], 2) + Math.Pow(array[3], 2));
                double distanceOC = Math.Sqrt(Math.Pow(array[4], 2) + Math.Pow(array[5], 2));
                if (distanceOA < distanceOB && distanceOA < distanceOC)
                {
                    Console.WriteLine($"({str} A ({array[0]}, {array[1]}) состовляет {Math.Round(distanceOA, 2)}");

                }
                else if (distanceOB < distanceOA && distanceOB < distanceOC)
                {
                    Console.WriteLine($"({str} A ({array[2]}, {array[3]}) состовляет {Math.Round(distanceOB, 2)}");

                }
                else
                {
                    Console.WriteLine($"({str} A ({array[4]}, {array[5]}) состовляет {Math.Round(distanceOC, 2)}");

                }

            }



            Console.WriteLine("Ведите номер четверти: ");
            int coordinateQuadrat = Convert.ToInt32(Console.ReadLine());
            if (coordinateQuadrat < 1 || coordinateQuadrat > 4)
            {
                Console.WriteLine("Такой четверти не существует!");
            }

            else if (coordinateQuadrat == 1)
            {
                int[] allPointsCoordinats = Point(0, 100, 0, 100);
                Distanse(allPointsCoordinats);
            }

            else if (coordinateQuadrat == 2)
            {
                int[] allPointsCoordinats = Point(-100, 0, 0, 100);
                Distanse(allPointsCoordinats);
            }

            else if (coordinateQuadrat == 3)
            {
                int[] allPointsCoordinats = Point(-100, 0, -100, 0);
                Distanse(allPointsCoordinats);
            }

            else
            {
                int[] allPointsCoordinats = Point(0, 100, -100, 0);
                Distanse(allPointsCoordinats);
            }




        }

        void task6()
        {

            // Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD
            int Input(string text)
            {
                Console.Write(text);
                int coordinate = Convert.ToInt32(Console.ReadLine());
                return coordinate;
            }

            int Ax = Input("Введите координату точки A: X = ");
            int Ay = Input("Введите координату точки A: Y = ");
            int Bx = Input("Введите координату точки B: X = ");
            int By = Input("Введите координату точки B: Y = ");
            int Cx = Input("Введите координату точки C: X = ");
            int Cy = Input("Введите координату точки C: Y = ");
            int Dx = Input("Введите координату точки D: X = ");
            int Dy = Input("Введите координату точки D: Y = ");

            double v1 = Bx - Ax;
            double w1 = By - Ay;
            double v2 = Dx - Cx;
            double w2 = Dy - Cy;
            if (v1 == 0 && w1 == 0 && v2 == 0 && w2 == 0)
            {
                Console.WriteLine("Отрезков не существует!");

            }
            else if (v1 == 0 && w1 == 0)
            {
                Console.WriteLine("Отрезка AB не существует!");
            }
            else if (v2 == 0 && w2 == 0)
            {

                Console.WriteLine("Отрезка CD не существует!");
            }

            double AB = Math.Sqrt(v1 * v1 + w1 * w1);
            double CD = Math.Sqrt(v2 * v2 + w2 * w2);
            double x1 = v1 / AB;
            double y1 = w1 / AB;
            double x2 = v2 / CD;
            double y2 = w2 / CD;
            double epsilon = 0.000001;
            if (Ax == Cx && Ay == Cy && Bx == Dx && By == Dy)
            {
                Console.WriteLine("Отрезки совпалают!");
            }
            if (Math.Abs(x1 - x2) < epsilon && Math.Abs(y1 - y2) < epsilon)
            {
                Console.WriteLine("Орезки параллельны!");
            }
            double t2 = (-w1 * Cx + w1 * Ax + v1 * Cy - v1 * Ay) / (w1 * v2 - v1 * w2);
            double t = (Cx - Ax + v2 * t2) / v1;
            if (t < 0 || t > 1 || t2 < 0 || t2 > 1)
            {
                Console.WriteLine("Пересечений нет!");
            }
            else
            {
                double Zx = Cx + v2 * t2;
                double Zy = Cy + v2 * t2;
                Console.WriteLine($"Отрезки пресекаются! Точка пересечения отрезка Z ({Zx}, {Zy}");

            }
        }

        void task7()

        {
            //Задача 4. Дан массив средних температур (массив заполняется случайно) за последние 10 лет.
            // На ввод подают номер месяца и год начали и конца. Определить самые высокие и низкие температуры 
            //для лета, осени, зимы и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.


            int Input(string text)
            {
                Console.Write(text);
                int number = Convert.ToInt32(Console.ReadLine());
                return number;

            }


            Random random = new Random();
            int[] temperature10Years = new int[120];
            for (int i = 0; i < temperature10Years.Length; i++)
            {
                temperature10Years[i] = random.Next(-50, 50);
            }
           
                int finish = 2022;
                int start = 2013;
                int startYear = Input("Введите номер года (2013 - 2022) (с какого года вы хотите посмотреть температуру воздуха) StartYear = ");
                int startMonth = Input("Введите месяц года StartMonth =  ");
                int finishYear = Input("Введите номер года (2013 - 2022) (до какого вы хотите посмтореть температуру воздуха) FinisYear = ");
                int finishMonth = Input("Введите месяц года FinishMonth = ");


                while (startYear < 2012 || finishYear > 2022)
                {
                    Console.WriteLine("Ошибка ввода! Такого года в базе нет!");


                }
                while (startYear > finishYear)
                {
                    Console.WriteLine("Ошибка ввода! Стартовый год не может быть чем финальный!");


                }
                while (startMonth <= 0 || startMonth > 12 || finishMonth <= 0 || finishMonth > 12)
                {
                    Console.WriteLine(" Ошибка ввода! Такого месяца не существует!");

                }


                int startIndex = (finish - finishYear) * 12 - 13 + startMonth;
                int finishIndex = (finish - startYear) * 12 - 13 + finishMonth;


                int[] indexWinter = new int[30];
                int[] indexSpring = new int[30];
                int[] indexSummer = new int[30];
                int[] indexAutumn = new int[30];

                int n = 5;
                int m = 2;
                int k = 8;
                int l = 0;
                for (int i = 0; i < indexSummer.Length; i += 3)
                {

                    indexSummer[i] = n;
                    indexSummer[i + 1] = n + 1;
                    indexSummer[i + 2] = n + 2;
                    indexSpring[i] = m;
                    indexSpring[i + 1] = m + 1;
                    indexSpring[i + 2] = m + 2;
                    indexAutumn[i] = k;
                    indexAutumn[i + 1] = k + 1;
                    indexAutumn[i + 2] = k + 2;
                    indexWinter[i] = l;
                    indexWinter[i + 1] = l + 1;
                    indexWinter[i + 2] = l + 11;

                    n += 12;
                    m += 12;
                    k += 12;
                    l += 12;
                }
                int sumWinterTemperature = 0;
                int sumSpringTemperature = 0;
                int sumSummerTemperature = 0;
                int sumAutumnTemperature = 0;
                int countWinter = 0;
                int countSpring = 0;
                int countSummer = 0;
                int countAutumn = 0;
                int minTempWinter = 0;
                int maxTempWinter = 0;
                int minTempSprig = 0;
                int maxTempSprig = 0;
                int minTempSummer = 0;
                int maxTempSummer = 0;
                int maxTempAutumn = 0;
                int minTempAutumn = 0;



                for (int i = startIndex; i < finishIndex; i++)
                {
                    for (int p = 0; p < indexWinter.Length; p++)
                    {
                        if (i == indexWinter[p])
                        {
                            sumWinterTemperature += temperature10Years[i];
                            countWinter++;
                            if (maxTempWinter < temperature10Years[i]) maxTempWinter = temperature10Years[i];

                            if (minTempWinter > temperature10Years[i]) minTempWinter = temperature10Years[i];

                        }

                        else if (i == indexSpring[p])
                        {
                            sumSpringTemperature += temperature10Years[i];
                            countSpring++;
                            if (maxTempSprig < temperature10Years[i]) maxTempSprig = temperature10Years[i];

                            if (minTempSprig > temperature10Years[i]) maxTempSprig = temperature10Years[i];

                        }


                        else if (i == indexSummer[p])
                        {
                            sumSummerTemperature += temperature10Years[i];
                            countSummer++;
                            if (maxTempSummer < temperature10Years[i]) maxTempSummer = temperature10Years[i];

                            if (minTempSummer > temperature10Years[i]) minTempSummer = temperature10Years[i];

                        }


                        else if (i == indexAutumn[p])
                        {
                            sumAutumnTemperature += temperature10Years[i];
                            countAutumn++;
                            if (maxTempAutumn < temperature10Years[i]) maxTempAutumn = temperature10Years[i];

                            if (minTempAutumn > temperature10Years[i]) minTempAutumn = temperature10Years[i];
                        }

                    }
                }

                Console.WriteLine($"В период с {startMonth} / {startYear} по {finishMonth} / {finishYear}");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($" Cредняя температура в зимнее время составляла {sumWinterTemperature / countWinter} ");
                Console.WriteLine($"Минимальная температура составляла {minTempWinter}, а максимальная {maxTempWinter}");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($" Cредняя температура в весенний период составляла {sumSpringTemperature / countSpring} ");
                Console.WriteLine($"Минимальная температура составляла {minTempSprig}, а максимальная {maxTempSprig}");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($" Cредняя температура в летний период составляла {sumSummerTemperature / countSummer} ");
                Console.WriteLine($"Минимальная температура составляла {minTempSummer}, а максимальная {maxTempSummer}");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($" Cредняя температура в зимний период составляла {sumWinterTemperature / countWinter} ");
                Console.WriteLine($"Минимальная температура составляла {minTempWinter}, а максимальная {maxTempWinter}");
        

        }


        Console.Clear();
        Console.WriteLine("Введите номер задачи 19, 21, 23, 1, 2, 3, 4, 5, 6 или 7: ");
        int task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 19: task19(); break;
            case 21: task21(); break;
            case 23: task23(); break;
            case 1: task1(); break;
            case 2: task2(); break;
            case 3: task3(); break;
            case 4: task4(); break;
            case 5: task5(); break;
            case 6: task6(); break;
            case 7: task7(); break;
            default: Console.WriteLine("Ошибка ввода!"); break;
        }


    }
}

