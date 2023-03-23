// Считываем данные с консоли
string? inLine = Console.ReadLine();

// Проверяем, что данные не пустые
if(inLine!=null);
{
    // Парсим введенное число
    int inNumber = int.Parse(inLine);

    int outNumber = inNumber*inNumber;

    // Выводим данные в консоль
    Console.WriteLine(outNumber);
}
