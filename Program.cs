namespace Arrays1OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        // ЗАДАНИЕ 1
        Console.WriteLine("ЗАДАНИЕ 1\n");

        int[] numberArray = { -24, 100, 24020, -13, 0 };

        int min = numberArray.Min(); // встроенная функция для нахождения минимального элемента
        int max = numberArray.Max(); // встроенная функция для нахождения максимального элемента
        int sum = numberArray.Sum(); // встроенная функция для подсчета суммы всех элементов

        Console.WriteLine($"Минимум: {min}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Сумма: {sum}");


        // ЗАДАНИЕ 2
        Console.WriteLine("\n\nЗАДАНИЕ 2\n");

        string[] wordArray = { "apple", "banana", "cherry" };
        Array.Reverse(wordArray); // встроенная функция для переворота массива

        foreach (string word in wordArray)
            Console.WriteLine(word);


        // ЗАДАНИЕ 3
        Console.WriteLine("\n\nЗАДАНИЕ 3\n");
        
        int[] numbers = { -45, 52, 178, -3, 0, 133, 444 }; // Объявление и инициализация массива целых чисел с произвольными значениями

        Array.Sort(numbers); // Встроенная функция Array.Sort() сортирует массив по возрастанию

        Console.WriteLine("Отсортированный массив:"); // Выводим сообщение о том, что сейчас будет выведен отсортированный массив
                                                      
        foreach (int number in numbers) // Цикл foreach проходит по каждому элементу массива и выводит его на экран
            Console.WriteLine(number); // Вывод текущего элемента массива


        // ПРАКТИЧЕСКОЕ ЗАДАНИЕ 1
        Console.WriteLine("\n\nПРАКТИЧЕСКОЕ ЗАДАНИЕ 1\n");

        double[] userArray1 = { 10, 5, 15, 0 }; // Произвольный массив
        double arraySum = 0; // Сумма элементов массива
        double average = 0; // Среднее арифметическое

        for (int i = 0; i < userArray1.Length; i++)
            arraySum += userArray1[i];

        average = arraySum / userArray1.Length;

        Console.WriteLine($"Среднее арифметическое элементов массива: {average}");


        // ПРАКТИЧЕСКОЕ ЗАДАНИЕ 2
        Console.WriteLine("\n\nПРАКТИЧЕСКОЕ ЗАДАНИЕ 2\n");

        string?[] stringArray = { "Привет", "Как дела?", "Сколько стоят яблоки?", "Разгул для моей шизофазии.", "Помогите." }; // Произвольный массив

        Console.WriteLine("Введите букву, с который должна начинаться строка: ");
        char startLetter = Convert.ToChar(Console.ReadLine());

        int startLetterStringCount = 0; // Колличество строк, начинающихся с заданной буквы

        foreach (string? line in stringArray)
            if (line?.Length > 0 && char.ToUpper(line[0]) == char.ToUpper(startLetter))
                startLetterStringCount++;

        Console.WriteLine($"Колличество строк, которые начинаются на букву {startLetter} равно: {startLetterStringCount}");
    } 
}
