// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] CreateNewArray ()
{
    Console.WriteLine("Input count of rows");
    int userRows = Convert.ToInt32(Console.ReadLine());
    while (userRows <= 0)
    {
        Console.WriteLine("Try again! Number of rows must be > 0");
        userRows = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Input count of columns");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    while (userColumns <= 0)
    {
        Console.WriteLine("Try again! Number of columns must be > 0");
        userColumns = Convert.ToInt32(Console.ReadLine());
    }

    int [,] createdArray = new int [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColumns; j++)
        {
            createdArray[i,j] = new Random().Next(0, 9);
        }
    }
    return createdArray;
}

void PrintNewArray (int [,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Console.Write(printedArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement (int [,] myArray)
{
    Console.WriteLine("Input number of rows element");
    int rowsPosition = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of columns element");
    int columnsPosition = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if (i == rowsPosition-1 && j == columnsPosition-1)
                Console.WriteLine($"Result is {myArray[rowsPosition - 1, columnsPosition - 1]}");
        }
    }
    if (rowsPosition > myArray.GetLength(0) || columnsPosition > myArray.GetLength(1))
        Console.WriteLine("Error. Element is not exist. Try again");
    else if (rowsPosition <= 0 || columnsPosition <= 0)
        Console.WriteLine("Error. Element is not exist. Try again");
}

int [,] arrayFromUser = CreateNewArray();
Console.WriteLine("Array is:");
PrintNewArray(arrayFromUser);
FindElement(arrayFromUser);