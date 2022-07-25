int num, sum = 0, r;
 
Console.WriteLine("Введите число : ");
 
num = int.Parse(Console.ReadLine());
 
while (num != 0)
 
    {
 
        r = num % 10;
 
        num = num / 10;
 
        sum = sum + r;
 
    }
 
Console.WriteLine("Сумма цифр числа : "+sum);
 
Console.ReadLine();


