﻿Console.Write("Введите перве число: ");
string firstnumber = Console.ReadLine();
int a = Convert.ToInt32(firstnumber);

if ((a%2)==0){
    Console.WriteLine("Число "+"`"+a+"`"+" чётное");
}
else{
    Console.WriteLine("Число "+"`"+a+"`"+" нечётное");
}