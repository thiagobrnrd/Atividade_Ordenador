using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Ordenador
{
    public class Quick


    {
        public static int[] Sort(int[] array)
        {
            return quickSort(array, 0, array.Length - 1);
        }

        public static int[] quickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                quickSort(array, leftIndex, j);

            if (i < rightIndex)
                quickSort(array, i, rightIndex);

            return array;
        }
    }
}
