using System;
using System.Collections.Generic;




namespace Matrix_Determinant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Matrix myMatrix = new Matrix(5, 10, 15, 20, 25, 30);

            // Get the determinant, which is equal to -50.
            Double determinant = myMatrix.Determinant;

            Console.WriteLine(determinant);
        }
    }
}
