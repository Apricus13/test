namespace Project;
class Program
{
    static void Main(string[] args)
    {
        int Input (string text)
        {
            Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());

        }
     /*void Task17()
{
    // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаётномер четверти плоскости, 
    //в которой находится эта точка
int x = Input("Ведите значение Х "); // Используем метод созданный выше
int y = Input("Ведите значение Y ");
if (x>0 && y>0)
{
 Console.WriteLine ($"Точка принадлежит 1 четверти");
}
else if (x<0 && y>0)
{
     Console.WriteLine($"Точка принадлежит 2 четверти");
}
else if (x<0 && y<0)
{
     Console.WriteLine($"Точка принадлежит 3 четверти");
}
else if (x>0 && y<0)
{
     Console.WriteLine($"Точка принадлежит 4 четверти");
}
else 
{
     Console.WriteLine($"Точка лежит на оси");
}
}
Task17();
 void Task18()
{
    // Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int num = Input("Введите номер четверти "); // Используем метод созданный выше

if (num==1)
{
 Console.WriteLine ($"то Х и У больше 0");
}
else if (num==2)
{
     Console.WriteLine($"Х<0, Y>0");
}
else if (num==3)
{
     Console.WriteLine($"Х<0, Y<0");
}
else if (num==4)
{
     Console.WriteLine($"Х>0, Y<0");
}
else 
{
     Console.WriteLine($"Номер четверти введен не верно");
}

}
Console.Clear();
Task18();

void Task21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
int Ax = Input("Введите координату Х точки  А:  "); // Используем метод созданный выше
int Ay = Input("Введите координату У точки  А:   ");
int Bx = Input("Введите координату Х точки  В:   "); // Используем метод созданный выше
int By = Input("Введите координату У точки  В:   ");
//int x = Math.Abs(Ax-Bx);
//int y = Math.Abs(Ay-By);
//int S = (int)Math.Sqrt((Ax-Bx)*(Ax-Bx) + (Ay-By)*(Ay-By));

 Console.WriteLine ($"Расстояние между точками А и В: {Math.Round(Math.Sqrt(Math.Pow((Ax-Bx),2) + (Ay-By)*(Ay-By)),2)}");
 }
 // Math.Round - округление
 // Math.Sqrt - квадратный корень

Console.Clear();
Task21();*/

void Task22()
{
     //Напишите программу, которая принимает на вход число (N)
    //  и выдаёт таблицу квадратов чисел от 1 до N.
int N = Input("Введите число:  "); // Используем метод созданный выше
//int a = 1;

 //  while (a <= N)
 //  {
 //   Console.WriteLine($"{a}^2 = {(Math.Pow((a),2))}");
 //  a++;
  // }
 for (int a = 1;a <= N; a++)
 {
     Console.WriteLine($"{a}^2 = {(Math.Pow((a),2))}");
 }

 }
 
Console.Clear();
Task22();
        
   /*    void Task9()
        {
        //Напишите программу, которая выводит случайное число из отрезка [10, 99]
        // и показывает наибольшую цифру числа.
        Random rnd = new Random(); //конструктор
        int number = rnd.Next(10,100);
        Console.WriteLine($"Выпало случайное число: {number}");
        int f_digit = number/10;
        Console.WriteLine($"Первая цифра числа: {f_digit}");
        int s_digit = number%10;
        Console.WriteLine($"Вторая цифра числа: {s_digit}");

        int max;
        if (f_digit>s_digit) max = f_digit;
        else max = s_digit;

        Console.WriteLine($"Наибольшая цифра числа: {max}");
    }
    Task9();
    
    void Task11()
    {
        //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    Random rnd = new Random(); //конструктор
    int number = rnd.Next(100,1000);
    Console.WriteLine(number);
    int f_digit = number/100;
    Console.WriteLine(f_digit);
    int s_digit = (number%100)%10;
    Console.WriteLine($"Ответ:{f_digit}{s_digit}");
    }
   // Task11();

void Task12()
{
    //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
    //Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine ("Введите первое число");
int f_num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine ("Введите второе число");
//int s_num = Convert.ToInt32(Console.ReadLine());
int s_num = Input("Ведите второе число"); // Используем метод созданный в строке 6
int div = s_num%f_num;
if (div==0)
{
    Console.WriteLine("Число " + s_num + " кратно, числу " + f_num);
}

*/
}
}