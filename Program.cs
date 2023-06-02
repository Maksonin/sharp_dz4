int Input(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task25(){
    // Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    double Pow(int num, int pow){
        double result = num;

        // Если показатель степени положительное число
        if (pow > 0){
            for(int i=1; i < pow; i++)
                result *= num;
        }
        // Если показатель степени отрицательное число
        else if (pow < 0){
            for(int i=1; i < Math.Abs(pow); i++)
                result *= num;
            result = 1 / result;
        }
        // другое
        else result = 1;
        
        return result;
    }

    int num = Input("Введите число - ");
    int pow = Input("Введите степень - ");

    Console.WriteLine($"{num} в степени {pow} = { Pow(num,pow) }");
    // Console.WriteLine($"С помощью метода Math.Pow. {num} в степени {pow} = { Math.Pow(num,pow) }");
}

void Task27(){
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
}

void Task29(){
    //  Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

}

void Menu() {
    Console.WriteLine("1 - Задача 25");
    Console.WriteLine("2 - Задача 27");
    Console.WriteLine("3 - Задача 29");
    switch (Input("Введите номер задачи - ")){
        case 1:
            Task25();
            break;
        case 2:
            Task27();
            break;
        case 3:
            Task29();
            break;
        default:
            Console.WriteLine("Задачи с таким номером не существует");
            break;
    }
}

Menu();



