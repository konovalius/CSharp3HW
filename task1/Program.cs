//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int number ;
while(true)
{
    Console.WriteLine("Введите пятизначное число");
    number = int.Parse(Console.ReadLine());
    if (number > 9999 && number <100000)
    {
        break;
    }
}
int number1 = number / 10000   ;
int number2 = (number / 1000)%10 ; 
int number3 = (number % 100)/10 ;
int number4 = number%10 ;


if (number1==number4 && number2==number3)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}


