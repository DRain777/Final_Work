﻿//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}