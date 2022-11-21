// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число N : ");
int Number = Convert.ToInt32(Console.ReadLine());

string NumText = Convert.ToString(Number);
if (NumText.Length < 6)
{
    if (NumText[0] == NumText[4] && NumText[1] == NumText[3])
    {
      Console.WriteLine(" Это палиндром ");
    }
    else 
    {
    Console.WriteLine(" Число не является палиндром ");
    }
}
else
{
    Console.WriteLine(" Вы ввели не пятизначное число ");
}


















// {
//     if (NumText[1] == NumText[5])  
//     {
//         if (NumText[2] == NumText[4])
//         {
//             Console.WriteLine(" Это палиндром ");
//         }

//     else
//     {
//         Console.WriteLine(" Число не является палиндром ");
//     }
// }
// else

//     Console.WriteLine(" Вы ввели не пятизначное число ");