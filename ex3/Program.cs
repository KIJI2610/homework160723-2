﻿System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++){
    System.Console.WriteLine(Math.Pow(i, 3));
}