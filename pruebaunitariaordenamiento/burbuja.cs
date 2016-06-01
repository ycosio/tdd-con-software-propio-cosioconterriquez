using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaunitariaordenamiento
{
    class burbuja
    {
        public void ordenar(int[] arr)
        {
            bool cambio = true;
            while (cambio)
            {
                cambio = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        cambio = true;
                    }
                }
            }
        }
    }
}
