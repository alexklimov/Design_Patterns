using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixDecorator
{
    public interface IMatrix
    {
        int getElement(int numberOfcol, int numberOfrow);
        void setElement(int element, int numberOfcol, int numberOfrow);
        int getSizeCols();
        int getSizeRows();
    }


    class Program
    {
        static void Main(string[] args)
        {
            //клиентская часть
            IMatrix matrix = new Matrix(2,2);
            matrix.setElement(3, 1, 1);
            matrix.setElement(0, 1, 2);
            matrix.setElement(4, 2, 1);
            matrix.setElement(5, 2, 2);

            IMatrix decorator_matrix = new TransMatrix(matrix);
            Console.WriteLine("Simple matrix : ");
            for (int i = 0; i < matrix.getSizeCols(); i++)
            {
                for (int j = 0; j < matrix.getSizeRows(); j++)
                {
                    Console.Write(matrix.getElement(i+1,j+1));
                }  
                Console.WriteLine("\n");
            }
            Console.WriteLine("transpon matrix : ");
            for (int i = 0; i < decorator_matrix.getSizeCols(); i++)
            {
                for (int j = 0; j < decorator_matrix.getSizeRows(); j++)
                {
                    Console.Write(decorator_matrix.getElement(i+1, j+1));
                }
                Console.WriteLine("\n");
            }
         
            Console.ReadKey();

                
        }

        // сумма элементов матрицы
         int Summa(IMatrix matrix)
        {
            int sum = 0;
            int sizecols = matrix.getSizeCols();
            int sizerows = matrix.getSizeRows();
            for (int i = 0; i <sizerows;i++)
                for (int j = 0; j < sizecols; j++)
                {
                    {
                        sum += matrix.getElement(i,j);
                    }
                }
            return sum;
        }     

    }

    public class Matrix : IMatrix
    {
        int cols; // кол-во строк
        int rows; // кол-во столбцов
        int[] matrix;
        // конструктор
        public Matrix(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;
            matrix = new int[cols*rows];
        }
        public int getElement(int numberOfcol, int numberOfrow) 
        {
            return matrix[rows * (numberOfrow - 1) + (numberOfcol - 1)];            
        }

        public void setElement(int element, int numberOfcol, int numberOfrow)
        {
            matrix[rows * (numberOfrow - 1) + (numberOfcol - 1)] = element;
        }

        public int getSizeCols()
        {
            return cols;
        }

        public int getSizeRows()
        {
            return rows;
        }
    }

    public class TransMatrix : IMatrix
    {
        IMatrix matrix;

        public TransMatrix(IMatrix matrix)
        {
            this.matrix = matrix;
        }

       public int getElement(int numberOfcol, int numberOfrow)
           {
            return this.matrix.getElement(numberOfrow, numberOfcol);
           }

       public void setElement(int element, int numberOfcol, int numberOfrow)
       {
           this.matrix.setElement(element, numberOfrow, numberOfrow);
       }

        public int getSizeCols()
        {
            return this.matrix.getSizeCols();
        }

        public int getSizeRows()
        {
            return this.matrix.getSizeRows();
        }
    }

}
