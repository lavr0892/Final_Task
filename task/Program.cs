void ReleaseMatrix(string[] matrix, string[] matrix2)
{
    int count = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= 3)
        {
            matrix2[count] = matrix[i];
            count++;          
        }
        Console.Write(matrix2[i]);

    }
}
    void PrintMatrix(string[] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.Write($"{matrix[i] + " "}");

        }
    }

    Console.Clear();
    Console.WriteLine("Введите элементы массива через пробел: ");
    string[] matrix = Console.ReadLine().Split(' ');
    string[] matrix2 = new string[matrix.Length];

    Console.WriteLine("Начальный массив: ");
    PrintMatrix(matrix);
    ReleaseMatrix(matrix, matrix2);
    Console.WriteLine();
    Console.WriteLine("Конечный массив: ");
    PrintMatrix(matrix2);
