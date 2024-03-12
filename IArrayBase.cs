using System;

namespace Task_34
{
    interface IArrayBase<T>
    {
        T[,] value { get; set; }
    }
}