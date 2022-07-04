﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixMultiplication
{
    
    static class Matrix
    {
        public static double[,] MatrixMultiply(double[,] matrix1, double[,] matrix2)
        { 
            int m1columns_m2rows = matrix1.GetLength(0);
            int m1rows = matrix1.GetLength(1);
            int m2columns = matrix2.GetLength(0);

            double[,] result = new double[m2columns, m1rows];

            for (int row = 0; row < m1rows; row++)
            {
                for (int column = 0; column < m2columns; column++)
                {
                    double accumulator = 0;
                    
                    
                    for (int cell = 0; cell < m1columns_m2rows; cell++)
                    {
                        

                        if (matrix1[cell, row] < 0)
                            throw new ArgumentException(string.Format("Matrix1 contains an invalid entry in cell[x, y] {0},{1}",cell, row));
                       

                        if(matrix2[column, cell] < 0)
                            throw new ArgumentException(
                                string.Format("Matrix2 contains an invalid entry in cell[x, y] {0},{1}", column, cell));
                         accumulator += matrix1[cell, row] * matrix2[column, cell];
                    }
                    result[column, row] = accumulator;
                }
            }
            return result;
        }
    }
}
