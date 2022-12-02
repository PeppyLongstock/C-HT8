/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен 
наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int[,] generatedArray = Generate2DArray(5, 3, 10);
print2dArray(generatedArray, "Forecomming Code");

for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); i++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (buff == generatedArray[i, j])
                {
                    count = count++;
                }
            }
            Console.WriteLine($"{buff}seen  {count}times");
            generatedArray[i - 1, j] = 0;
        }
    }
}
int minRowSum = int.MaxValue, indexMinRow = 0;
 
             for (int i = 0; i < n1; i++)
             {
                int rowSum = 0;
                for (int j = 0; j < n2; j++)
                    rowSum += A[i, j];
                
                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
             }
 
             Console.WriteLine("Строка с минимальной суммой элементов");
                 for(int j = 0;j<n2;j++)
                      Console.Write(A[indexMinRow, j] + "\t");