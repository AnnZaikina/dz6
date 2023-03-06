/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();
Console.WriteLine("Введите значения b1, k1, b2 и k2 через пробел");

string [] st = Console.ReadLine().Split ('');
int k1=int.Parse (st[0]);
int b1=int.Parse (st[1]);
int k2=int.Parse (st[2]);
int b2=int.Parse (st[3]);

int y =k1 * x +b1;
int x =(b2-b1)/(k1-k2);
int M = 
y = k2 * x + b2;
k1==k2