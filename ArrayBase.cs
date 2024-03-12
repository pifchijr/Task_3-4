using System;

namespace Task_34
{
    public abstract class ArrayBase<T> : IArrayBase<T>
    {
        public T[,] value{ get; set; }

        public ArrayBase(int rows, int cols, bool fillByHand)
        {
            this.value = (T[,])(fillByHand ? this.FillByHand(rows, cols) : this.FillByRnd(rows, cols));
        }
        
        public abstract Array FillByHand(int rows, int cols);

        public abstract Array FillByRnd(int rows, int cols);
    }
}