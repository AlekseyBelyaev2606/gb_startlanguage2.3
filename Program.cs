Console.Clear();
Console.WriteLine("Введите  число");
int N = int.Parse(Console.ReadLine());
if (N > 0 && N < 8)
{
    switch (N)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Будний день");
            break;

        case 6:
        case 7:
            Console.WriteLine("Выходной");
            break;
    }

}
else
{
    Console.WriteLine("Вы ввели неправильное число");
}