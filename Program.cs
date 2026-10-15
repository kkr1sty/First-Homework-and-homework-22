                                                                                   //Первое дз

//Меняем цвет текста
Console.ForegroundColor = ConsoleColor.DarkYellow;
//Информация
Console.Write("Омлет - минутка в кружке\n\n\nИнгредиенты\n\n• Куриное яйцо — 2 штуки\n• Молоко — 2 столовые ложки\n• Тёртый сыр — 1 столовая ложка\n• Соль и перец — по одной щепотке\n\nПриготовление\n\n1.Разбейте яйца прямо в кружку, пригодную для микроволновки.\n2.Добавьте молоко, соль, перец и тщательно взбейте всё вилкой.\n3.Всыпьте тёртый сыр и ещё раз слегка перемешайте.\n4.Поставьте кружку в микроволновку на 1, 5–2 минуты при максимальной мощности.\nНажмите Enter для выхода...");
//Ждем энтер для выхода
Console.Read();





                                                                          //Дз проработать и изучить

void Job(string name,int year,string company="Неизвестно")
{
    Console.WriteLine($"Имя:\t{name}\nСтаж работы\t{year}\n Компания\t{company}");
}
Job("Никита", 15);



                                                                          //Анкета

while (true) 
{   
    Console.Clear();
    Console.Write("Ваше имя:  ");
    string name = Console.ReadLine();
    Console.Write("Ваша фамилия:  ");
    string surName = Console.ReadLine();
    Console.Write("Ваша дата рождения (год):  ");
    var dateBirthday = Console.ReadLine();
    //Если пользователь ввел правильное число
    if (int.TryParse(dateBirthday, out int number))
    {
        anketa();
        return;
    }
    //Если неправильное число
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка ввода.Нажмите enter для повтора...");
        Console.ResetColor();
        Console.ReadKey(true);
    }

    //Вывод информации
    void anketa()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        var age = 2026 - number;
        Console.WriteLine($"Новый профиль создан!\n\nИмя:  {name}\nВозраст:  {age}\nФамилия:  {surName}");
    }
} 

