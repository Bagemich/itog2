Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
  string[] originalArray = new string[n];
        string[] newArray;

        Console.WriteLine("Введите строки:");
        for (int i = 0; i < n; i++)
        {
            originalArray[i] = Console.ReadLine();
        }

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                count++;
            }
        }

        newArray = new string[count];
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[j] = originalArray[i];
                j++;
            }
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(originalArray[i]);
        }

        Console.WriteLine("Новый массив:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(newArray[i]);
        }

        Console.ReadLine();
    
