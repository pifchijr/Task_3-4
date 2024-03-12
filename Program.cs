using System;

namespace Task_34
{
    class Program
    {
        static void Main()
        {
            IArrayBase[] array = new ArrayBase[2];
            array[0] = new Array1D<int>(3);
            array[0] = new Array1D<double>(3);
            array[0] = new Array1D<bool>(3);
            array[0] = new Array1D<string>(3);
            array[1] = new Array2D<int>(3, 3);
            array[0] = new Array2D<double>(3, 3);
            array[0] = new Array2D<bool>(3, 3);
            array[0] = new Array2D<string>(3, 3);

            foreach (ArrayBase item in array)
            {
                (item as IPrinter)?.Print();
                Console.WriteLine("");
            }

            Console.WriteLine("----------");

            IPrinter[] printable = new IPrinter[2];
            printable[0] = new Array1D<int>(4);
            array[0] = new Array1D<double>(4);
            array[0] = new Array1D<bool>(4);
            array[0] = new Array1D<string>(4);
            printable[1] = new Array2D<int>(4, 4);
            array[0] = new Array2D<double>(4, 4);
            array[0] = new Array2D<bool>(4, 4);
            array[0] = new Array2D<string>(4, 4);

            foreach (IPrinter item in printable)
            {
                item.Print();
                Console.WriteLine("");
            }
        }
    }
}