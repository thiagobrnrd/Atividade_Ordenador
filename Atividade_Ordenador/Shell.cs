using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Ordenador
{
    public class Shell
    {
        public static int[] ShellSort(int[] array)
        {
            for (int interval = array.Length / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < array.Length; i++)
                {
                    var currentKey = array[i];
                    var k = i;

                    while (k >= interval && array[k - interval] > currentKey)
                    {
                        array[k] = array[k - interval];
                        k -= interval;
                    }

                    array[k] = currentKey;
                }
            }

            return array;
        }
    }
}
