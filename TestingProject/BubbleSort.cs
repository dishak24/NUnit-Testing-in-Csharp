using System;
using System.Collections.Generic;
using System.Text;

namespace TestingProject
{
    public class BubbleSort
    {
        public int[] SortArray(int[] array)
        {
            for ( int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

    }
}
