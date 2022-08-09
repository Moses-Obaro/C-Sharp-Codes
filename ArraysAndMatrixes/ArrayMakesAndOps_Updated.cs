using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Arrays
    {
        // method to create a 2-dimensional array
        public int[,] GetDim2Array()
        {
            Console.WriteLine("Generating a 2d Array {2d arrays can be used to create matrixes}");
            Console.Write("Number of rows: ");
            
            if (int.TryParse(Console.ReadLine(), out int rows))
            {
            }
            else
            {
                Console.WriteLine("Wrong value entered");
            }
            int rowNumber = rows;
            
            Console.Write("Number of columns: ");
            if (int.TryParse(Console.ReadLine(), out int cols))
            {
            }
            else
            {
                Console.WriteLine("Wrong value entered");
            }
            int colNumber = cols;
            
            int[,] Dim2Array = new int[rowNumber, colNumber];
            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < colNumber; j++)
                {
                    Console.Write("Element [{0}, {1}] : ", i, j);
                    if (int.TryParse(Console.ReadLine(), out int element))
                    {
                    }
                    else
                    {
                        Console.WriteLine("Wrong value entered");
                    }
                    Dim2Array[i, j] = element;
                }
            }
            Console.WriteLine();
            return Dim2Array;

        }

        
        // method to display a 2-dimensional array
        public void PrintDim2Array(int[,] Array)
        {
            Console.WriteLine("\nThis is the matrix you created:");
            // row loop
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Console.Write("\n");
                //column loop
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", Array[i, j]);
                }
                //Console.WriteLine();
            }
            Console.WriteLine("\nThe matrix you created is a {0}x{1} matrix", Array.GetLength(0), Array.GetLength(1));
        }

        // Note: Matrices that have determinants must be square matrices i.e. length of dimension 1 (rows) equals length of dimension 0 (columns)
        // method to get the determinant of matrices (2x2 matrices, 3x3 matrices and 4x4 matrices)
        public int GetDeterminant(int[,] M)
        {

            int determinant;
            if (M.GetLength(0) == 2 && M.GetLength(1) == 2)
            {
                determinant = (M[0, 0] * M[1, 1]) - M[0, 1] * M[1, 0];
            }
            else if (M.GetLength(0) == 3 && M.GetLength(1) == 3)
            {
                determinant = M[0, 0] * ((M[1, 1] * M[2, 2]) - (M[1, 2] * M[2, 1]))
                            - M[0, 1] * ((M[1, 0] * M[2, 2]) - (M[2, 0] * M[1, 2]))
                            + M[0, 2] * ((M[1, 0] * M[2, 1]) - (M[2, 0] * M[1, 1]));
            }
            else if (M.GetLength(0) == 4 && M.GetLength(1) == 4)
            {
                determinant = M[0, 0] * (M[1, 1] * ((M[2, 2] * M[3, 3]) - (M[3, 2] * M[2, 3])) - M[1, 2] * ((M[2, 1] * M[3, 3]) - (M[3, 1] * M[2, 3])) + M[1, 3] * ((M[2, 1] * M[3, 2]) - (M[3, 1] * M[2, 2])))
                            - M[0, 1] * (M[1, 0] * ((M[2, 2] * M[3, 3]) - (M[3, 2] * M[2, 3])) - M[1, 2] * ((M[2, 0] * M[3, 3]) - (M[3, 0] * M[2, 3])) + M[1, 3] * ((M[2, 0] * M[3, 2]) - (M[3, 0] * M[2, 2])))
                            + M[0, 2] * (M[1, 0] * ((M[2, 1] * M[3, 3]) - (M[3, 1] * M[2, 3])) - M[1, 1] * ((M[2, 0] * M[3, 3]) - (M[3, 0] * M[2, 3])) + M[1, 3] * ((M[2, 0] * M[3, 1]) - (M[3, 0] * M[2, 1])))
                            - M[0, 3] * (M[1, 0] * ((M[2, 1] * M[3, 2]) - (M[3, 1] * M[2, 2])) - M[1, 1] * ((M[2, 0] * M[3, 2]) - (M[3, 0] * M[2, 2])) + M[1, 2] * ((M[2, 0] * M[3, 1]) - (M[3, 0] * M[2, 1])));
            }
            else
            {
                determinant = 0;
            }
            return determinant;
        }
        // method to create a 3-dimensional array
        public int[,,] GetDim3Array()
        {
            Console.WriteLine("\nThis is a 3 dimensional array");
            Console.Write("How many columns do you want in the inner array? ");
            if (int.TryParse(Console.ReadLine(), out int cols))
            {
            }
            else
            {
                Console.WriteLine("Wrong value entered");
            }
            int colNumber = cols;

            Console.Write("How many rows do you want in inner array ");
            if (int.TryParse(Console.ReadLine(), out int rows))
            {
            }
            else
            {
                Console.WriteLine("Wrong value entered");
            }
            int rowNumber = rows;

            Console.Write("How many tables do you want the 3D array to hold? ");
            if (int.TryParse(Console.ReadLine(), out int arrays))
            {
            }
            else
            {
                Console.WriteLine("Wrong value entered");
            }
            int arrayNumber = arrays;
            int[,,] Dim3Array = new int[arrayNumber, rowNumber, colNumber];

            // Array loop
            for (int i = 0; i < Dim3Array.GetLength(0); i++)
            {
                // row loop
                for (int j = 0; j < Dim3Array.GetLength(1); j++)
                {
                    // column loop
                    for (int a = 0; a < Dim3Array.GetLength(2); a++)
                    {

                        Console.Write("Element [{0}, {1}] in Table {2} : ", j, a, i);
                        Dim3Array[i, j, a] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            return Dim3Array;
        }

        // method to display a 3-dimensional array
        public void PrintDim3Array(int[,,] Array)
        {
            Console.WriteLine("\nThis is the 3D array you created:\n");
            // To loop through arrays
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                //row loop
                for (int j = 0; j < Array.GetLength(1); j++)
                {   
                    //column loop
                    for (int a = 0; a < Array.GetLength(2); a++)
                    {
                        Console.Write("\t"+ Array[i, j, a]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("The 3D array you created has {0} rows, {1} " +
                              "columns and {2} tables", Array.GetLength(1), Array.GetLength(2), Array.GetLength(0));
        }

        // method to multiply 3-dimensional arrays
        public int[,] MultDim2Array(int[,] mat1, int[,] mat2)
        {
            //Console.WriteLine("This method multiplies two matrixes\n");
            //Console.WriteLine("Creating the first matrix.....\n");
            //mat1 = GetDim2Array();
            int col1 = mat1.GetLength(1);
            int row1 = mat1.GetLength(0);
            //Console.WriteLine("Creating the second matrix.....\n");
            //mat2 = GetDim2Array();
            int col2 = mat2.GetLength(1);
            int row2 = mat2.GetLength(0);

            if (col1 != row2)
            {
                Console.WriteLine("\nArray multiplication not possible");
                Console.WriteLine("For multiplication columns of matrix 1 must be equal to rows of matrix 2");
                int[,] result = new int[1, 1] { { 0 } };
                return result;
                
            }
            else
            {
                int[,] m1 = (int[,])mat1;
                int[,] m2 = (int[,])mat2;
                int[,] result = new int[row1, col2];
                // row loop
                for (int i = 0; i < row1; i++)
                {
                    // column loop
                    for (int j = 0; j < col2; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < 2; k++)
                        {
                            result[i, j] += m1[i, k] * m2[k,j];
                        }
                        
                    }

                }
                return result;
            }
            
        }

        public void Print2DMultResult(int[,] Array)
        {
            Console.WriteLine("\nThis is the result of the matrix multiplication:");
            // row loop
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Console.Write("\n");
                //column loop
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", Array[i, j]);
                }
                //Console.WriteLine();
            }
            Console.WriteLine("\nThe matrix that resulted is a {0}x{1} matrix", Array.GetLength(0), Array.GetLength(1));
        }
        public int[,,] MultDim3Array(int[,,] Array)
        {
            int[,,] result = new int[,,] {}; 
            //Array = GetDim3Array();
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        result[i, j, k] += Array[i, j, k] * Array[i, j, k];
                    }
                }
            }

            return result;
        }
        
        
    }
}
