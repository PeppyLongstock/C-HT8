/*
            Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
            значения b1, k1, b2 и k2 задаются пользователем.
            b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
            */

            int GetNumberFromUser(string message)
            {
                int result = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(message);
                Console.ResetColor();
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }

            double InterSectionPoint (double b1, double k1, double b2, double k2)
            {
            
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                // int y = k2 * x + b2;
                Console.WriteLine($"Coordinates of the point of intersection of two straight lines are ({x};{y})");
                return x;
            }
            Console.WriteLine("Enter the values of the variables b1, k1, b2, k2 to find the point of intersection ");
            Console.WriteLine("two straight lines given by the equations y = k1 * x + b1, y = k2 * x + b2");
            int b1 = GetNumberFromUser ("Enter the values of b1: ");
            int k1 = GetNumberFromUser ("Enter the values of k1: ");
            int b2 = GetNumberFromUser ("Enter the values of b2: ");
            int k2 = GetNumberFromUser ("Enter the values of k2: ");
            double result = InterSectionPoint (b1, k1, b2, k2);
            /*Task43*/