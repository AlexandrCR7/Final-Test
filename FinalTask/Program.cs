﻿
string [] Array = new string [4];

Array[0] = "xxx";
Array[1] = "xx";
Array[2] = "xx";
Array[3] = "x";

int summ = 0;

for(int i = 0; i < 4; i++)
{
    if(Array[i].Length <= 2)
    {
        summ += 1;
    }
    System.Console.WriteLine(Array[i]);
}

System.Console.WriteLine("Кол-во ячеек в массиве <= 2 равно " + summ);

string [] Array1 = new string [summ];

for(int i = 0; i < 4; i++)
{
    int j = 0;
    if(Array[i].Length <= 2)
    {
        Array1[j] = Array[i];
        System.Console.WriteLine(Array1[j]);
        j++;
    }
}









