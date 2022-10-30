﻿/*
* Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.
*/

namespace H3E3_RationalFraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RationalFraction left;
            RationalFraction right;
            ConsoleUtils.InputData(out left, out right);
            ConsoleUtils.OutputData(left, right);
        }
    }
}