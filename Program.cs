// метод для вывода запроса в консоль на ввод числа и чтение числа из консоли
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
    int SumOfNum(int num){
        int result = 0;

        while (num > 0){
            result += num % 10;
            num /= 10;
        }

        return result;
    }

    int num = Input("Введите число - ");
    Console.WriteLine($"Сумма цифр числа {num} равна {SumOfNum(num)}");
}

void Task29(){
    //  Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

    // метод для заполнения переденного массива случайными числами (по умолчанию от -10 до 10)
    void SetArray(int[] array, int min_random = -10, int max_random = 10){
        Random rand = new Random();

        for(int i = 0; i < array.Length; i++){
            array[i] = rand.Next(min_random , max_random);
        }
    }

    // метод для вывода значений элементов массива в консоль
    void PrintArray(int[] array){
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
            Console.WriteLine();
    }

    // метод для сортировки массива
    void SortArray(int[] array){
        int tmp;

        for(int i1 = 0; i1 < array.Length; i1++){
            for(int i = 0; i < array.Length - 1; i++){
                if(Math.Abs(array[i]) > Math.Abs(array[i+1])) {
                    tmp = array[i];
                    array[i] = array[i+1];
                    array[i+1] = tmp;
                }
            }
        }

    }

    int[] array = new int[8];

    SetArray(array, -100, 100);

    PrintArray(array);
    Console.WriteLine("------------------------------");
    SortArray(array);
    PrintArray(array);
    Console.WriteLine("------------------------------");
}

// метод для вывода меню выбора задач
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



