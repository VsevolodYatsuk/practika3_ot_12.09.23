using System;

class Program
{
    static void Main()
    {
        // Преобразовал из меньшего целого числа в большее
        int smallInt = 42;
        long bigInt = smallInt;

        Console.WriteLine($"Меньшее целое число: {smallInt}");
        Console.WriteLine($"Большее целое число после преобразования: {bigInt}");

        // Преобразовал из производного класса в базовый
        DerivedClass derivedObj = new DerivedClass();
        BaseClass baseObj = derivedObj;

        Console.WriteLine($"Объект производного класса: {derivedObj.GetType()}");
        Console.WriteLine($"Объект базового класса после преобразования: {baseObj.GetType()}");

        // Преобразовал из строки в число
        string numStr = "12345";
        int num = int.Parse(numStr);

        Console.WriteLine($"Строка: {numStr}");
        Console.WriteLine($"Целое число после преобразования: {num}");

        // Преобразовал из массива байтов в целое число
        byte[] byteArray = { 0x01, 0x02, 0x03, 0x04 };
        int intFromBytes = BitConverter.ToInt32(byteArray, 0);

        Console.WriteLine("Массив байтов:");
        foreach (byte b in byteArray)
        {
            Console.Write($"{b:X} ");
        }
        Console.WriteLine($"\nЦелое число после преобразования: {intFromBytes}");

        // Преобразовал из строки в число с использованием TryParse
        string numStr2 = "56789";
        int num2;
        if (int.TryParse(numStr2, out num2))
        {
            Console.WriteLine($"Строка: {numStr2}");
            Console.WriteLine($"Целое число после TryParse преобразования: {num2}");
        }
        else
        {
            Console.WriteLine($"Невозможно преобразовать строку '{numStr2}' в число.");
        }

        string invalidNumStr = "56789A"; // Добавил букву 'A' в число, что бы вызвать ошибку
        int invalidNum;
        if (int.TryParse(invalidNumStr, out invalidNum))
        {
            Console.WriteLine($"Строка: {invalidNumStr}");
            Console.WriteLine($"Целое число после TryParse преобразования: {invalidNum}");
        }
        else
        {
            Console.WriteLine($"Невозможно преобразовать строку '{invalidNumStr}' в число.");
        }
    }
}

class BaseClass { }

class DerivedClass : BaseClass { }
