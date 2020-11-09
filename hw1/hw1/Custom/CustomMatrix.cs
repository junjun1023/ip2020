using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Another class
/// https://stackoverflow.com/questions/1348594/is-there-a-c-sharp-generic-constraint-for-real-number-types
/// </summary>
/// TODO:


namespace hw1.Custom
{
    public class CustomMatrix
    {
        public CustomMatrix() { } // default Constructor

        public T[,] MatrixMultiply<T>(T[,] arr1, T[,] arr2) where T : struct, 
                                                                        IComparable,
                                                                        IComparable<T>,
                                                                        IConvertible,
                                                                        IEquatable<T>,
                                                                        IFormattable
        {
            if (arr1.GetLength(1) != arr2.GetLength(0))
            {
                throw new System.ArgumentException("Dimension of arr2 cannot match to arr1", "arr2");
            }

            T[,] ret = new T[arr1.GetLength(0), arr2.GetLength(1)];
            for (var i = 0; i < arr1.GetLength(0); i++)
            {
                
                for (var j = 0; j < arr2.GetLength(1); j++)
                {
                    dynamic sum = 0;
                    for (var k = 0; k < arr1.GetLength(1); k++)
                    {
                        dynamic val1 = arr1[i, k], val2 = arr2[k, j];
                        sum += val1 * val2;
                    }

                    ret[i, j] = sum;

                }

            }



            return ret;
        }


        public T[,] MatrixTranspose<T>(T[,] arr1, T[,] arr2) where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            if (arr1.GetLength(1) != arr2.GetLength(0))
            {
                throw new System.ArgumentException("Dimension of arr2 cannot match to arr1", "arr2");
            }

            T[,] ret = new T[arr1.GetLength(0), arr2.GetLength(1)];
            for (var i = 0; i < arr1.GetLength(0); i++)
            {

                for (var j = 0; j < arr2.GetLength(1); j++)
                {
                    dynamic sum = 0;
                    for (var k = 0; k < arr1.GetLength(1); k++)
                    {
                        dynamic val1 = arr1[i, k], val2 = arr2[k, j];
                        sum += val1 * val2;
                    }

                    ret[i, j] = sum;

                }

            }

            return ret;
        }



    }
}
