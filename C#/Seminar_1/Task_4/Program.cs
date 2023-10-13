using System.Runtime.CompilerServices;

Console.Write("Введите число: ");
string firstnumber = Console.ReadLine();
int a = Convert.ToInt32(firstnumber);
int count = 1;

while (count<=a){
    if ((count%2)==0){
        Console.Write(count+"\t");
    }
    count = count + 1;
}