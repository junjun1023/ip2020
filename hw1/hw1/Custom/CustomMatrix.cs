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

        private static CustomMatrix service = new CustomMatrix();

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


        public T[,] MatrixTranspose<T>(T[,] arr1) where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {
            var cols = arr1.GetLength(1);
            var rows = arr1.GetLength(0);

            T[,] ret = new T[cols, rows];
            for (int i = 0; i < cols; ++i)
            {
                for (int j = 0; j < rows; ++j)
                {
                    ret[j, i] = arr1[i, j];
                }
            }

            return ret;
        }


        public T[,] MatrixMulConstant<T>(T[,] arr1, T constant) 
            where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {

            // V[,] ret = new V[arr1.GetLength(0), arr1.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    dynamic val = arr1[i, j];
                    arr1[i, j] = val * constant;
                }
            }

            return arr1;
        }



        public T[,] MatrixInverse<T>(T[,] arr1) where T : struct,
            IComparable,
            IComparable<T>,
            IConvertible,
            IEquatable<T>,
            IFormattable
        {

            var rows = arr1.GetLength(0);
            var cols = arr1.GetLength(1);

            if (rows != cols)
            {
                throw new System.ArgumentException("Only square matrix can be inversed.", "arr1");
            }

            
            dynamic delta = 0;

            if (rows == 1)
            {
                return arr1;
            } else if (rows == 2)
            {

            } else if (rows == 3)
            {
                dynamic a = arr1[0, 0];
                dynamic b = arr1[0, 1];
                dynamic c = arr1[0, 2];
                dynamic d = arr1[1, 0];
                dynamic e = arr1[1, 1];
                dynamic f = arr1[1, 2];
                dynamic g = arr1[2, 0];
                dynamic h = arr1[2, 1];
                dynamic i = arr1[2, 2];

                delta = a * (e * i - f * h) +
                                b * (f * g - d * i) +
                                c * (d * h - e * g);
                delta = 1.0 / delta;

                T[,] ret = new T[3,3];

                ret[0, 0] = e * i - f * h;
                ret[0, 1] = c * h - b * i;
                ret[0, 2] = b * f - c * e;
                ret[1, 0] = f * g - d * i;
                ret[1, 1] = a * i - c * g;
                ret[1, 2] = c * d - a * f;
                ret[2, 0] = d * h - e * g;
                ret[2, 1] = b * g - a * h;
                ret[2, 2] = a * e - b * d;

                ret = service.MatrixMulConstant<T>(ret, delta);

                return ret;
            }
            else if (rows > 3)
            {
                throw new System.ArgumentException("Input should be 2*2 or 3*3 square matrix.", "arr1");
            }
            

            


            return arr1;
        }

    }
}
