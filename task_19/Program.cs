Console.Write("Напишите пятизначное число: ");
string stroka = Console.ReadLine();
if (stroka[0] == stroka[4] && stroka[1] == stroka[3]) Console.Write("Это палиндромон");
else Console.Write("Это не палиндромон");