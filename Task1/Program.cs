int InputInt(string message)                            //название метода
{
    Console.Write($"{message}> ");                      //вывод приглашения ко вводу
    int value;                                          //объявление переменой
    if (int.TryParse(Console.ReadLine(), out value))    //проверка условия корректности ввода + ввод со строки
    {                                                   //если конвертация строки прошла правильно,то мы попадаем в ветку,
        return value;                                   //которая находится в скобка после наименования функции. Если да,
    }                                                   //то выдает первое значение (ввод со строки). Нет - второе (out)
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                //елси TryParse не сработало, выходим из программы (Exit) с кодом 1
    return 0;                                           //нужна для комиляции.
}

int enterNumberA = InputInt;
int enterNumberB = InputInt;

Console.Write("Введите число A: ");
enterNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
enterNumberB = Convert.ToInt32(Console.ReadLine());

result = enterNumberA;

for (int i = 2; i <= enterNumberB; i++)
{
    result *= enterNumberA;
}

Console.WriteLine($"{enterNumberA}^{enterNumberB} = {result}");
break;