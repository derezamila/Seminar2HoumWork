/*
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(){
    Console.Write("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int dec = num / 100;
    int ed = num % 10;
    int result = (num - dec*100 - ed)/10;
    return result;
}
int result = CutNumber();
Console.WriteLine("Вторая цифра числа - "+ result);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99){
       Method();
}
else Console.WriteLine("Третьей цифры в числе нет");

void Method(){
    int a = num;
    double n = 0;
    double m = 0;
    while(a > 0){
        a = a / 10;
        n++;
    }
    double sq = Math.Pow(10, n-2);
    int square = Convert.ToInt32(sq);
    int b = num % square;
    if (n == 3){
        double sq1 = Math.Pow(10, m);
        int square1 = Convert.ToInt32(sq1);
        int c = b / square1;
        Console.WriteLine("Третья цифра числа - "+ c);
    }
    else {
          double sq1 = Math.Pow(10, m+1);
          int square1 = Convert.ToInt32(sq1);
          int c = b / square1;
          Console.WriteLine("Третья цифра числа - "+ c);
    }
        
}
*/

// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 7){
    Method();
}
else Console.WriteLine("Дня недели с таким номером нет");

void Method(){
    if (num == 6 || num == 7){
        Console.WriteLine("Это выходной день");
    }
    else Console.WriteLine("Это не выходной день");

}
