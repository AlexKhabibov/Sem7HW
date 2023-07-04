// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] CreateArray ()
{
    Console.WriteLine("Input count of rows)");
    int userRows = Convert.ToInt32(Console.ReadLine());
    while (userRows <= 0)
    {
        Console.WriteLine("Try again! Counts of rows must be > 0");
        userRows = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Input count of columns)");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    while (userColumns <= 0)
    {
        Console.WriteLine("Try again! Count of columns must be > 0");
        userColumns = Convert.ToInt32(Console.ReadLine());
    }
    
    double [,] createdArray = new double [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColumns; j++)
        {
            createdArray[i,j] = Math.Round((new Random().Next(-10, 10+1) + new Random().NextDouble()), 2);
        }
    }
    return createdArray;
}

void PrintArray (double [,] usersArray)
{
    for (int i = 0; i < usersArray.GetLength(0); i++)
    {
        for (int j = 0; j < usersArray.GetLength(1); j++)
        {
            Console.Write(usersArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] newArray = CreateArray();
PrintArray(newArray);