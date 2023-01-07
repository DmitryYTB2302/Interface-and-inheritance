using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабораторная_7_по_методичке
{
    abstract class perem 
    {
        public perem() { }
		protected int v;
        public int valuePer
        {
            get { return v; }
            set { v = value; }
        }
       
    }
    class mass : IMast2
    {
        public mass() { }

        public int Plus(int[] arr)
        {
            int summ = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                summ = summ + arr[i];
            }
			return summ;
        }
        public int Umn(int[] arr)
        {
            int proiz = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                proiz = proiz * arr[i];
            }
            return proiz;
        }
        public int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)//сортировка пузырьком
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
    sealed class matr : IMast
    {
        public matr() { }
        public int[,] Plus(int[,] array,int[,] array2)
        {
            /*int summ = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    summ = summ + arr[j, i];
                }
            }
            return summ;*/
            int[,] additionArr = new int[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array2.GetLength(0); j++)
                {
                    /*for (int k = 0; k < additionArr.GetLength(0); k++)*/
                    //{
                    additionArr[i, j] = array[i, j] + array2[i, j];
                    //}
                }
            }
            return additionArr;
        }
        public int[,] Umn(int[,] arr,int[,] arr2)
        {
            /* int proiz = 1;
             for (int i = 0; i < arr.GetLength(1); i++)
             {
                 for (int j = 0; j < arr.GetLength(0); j++)
                 {
                     proiz = proiz * arr[j, i];
                 }
             }
             return proiz;*/
            int[,] multArr = new int[arr.GetLength(1), arr.GetLength(0)];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < multArr.GetLength(0); k++)
                    {
                        multArr[i, j] += arr[i, k] * arr2[k, j];
                    }
                }
            }
            return multArr;

        }
        public int[,] Sort(int[,] arr)
        {
            int[] row = new int[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    row[j] = arr[i, j];
                BubbleSort(row);
                Insert(true, i, row, arr);
            }

            int[] col = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                    col[j] = arr[j, i];
                BubbleSort(col);
                Insert(false, i, col, arr);
            }
            return arr;
        }
        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
            {
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
            }
        }
        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }
    }
    interface IMast 
    {
        int[,] Plus(int[,] array,int[,] array2 );
        int[,] Umn(int[,] arr,int[,] arr2);
        int[,] Sort(int[,] arr);
    }
    interface IMast2
    {
        int Plus(int[] array);
        int Umn(int[] arr);
        int[] Sort(int[] arr);
    }
}
