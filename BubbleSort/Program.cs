namespace BubbleSort;
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("El array ha sido ordenado: ");
        int[] arrayOrdenado = bubbleSort(new int[]{5,3,2});

        // Recorre el array ordenado para mostrarlo en pantalla.
        for(int i = 0; i < arrayOrdenado.Length; i++){

            if(i == arrayOrdenado.Length - 1)
                Console.Write(arrayOrdenado[i]);
            else
                Console.Write(arrayOrdenado[i] + ", ");
            
        }

        static int[] bubbleSort(int[] array){

            // array.length - 1 para que no pueda llegar al penultimo elemento y compare el mismo numero en el
            // bucle interno
            for(int i = 0; i < array.Length - 1; i++){
                bool swap = false;

            // array.Length - 1 - i para que no tenga en cuenta los elementos al final del array que
            // ya estan ordenados y disminuir la cantidad de comparaciones.
                for(int j = 0; j < array.Length - 1 - i; j++){

                    if(array[j] > array[j + 1]){
                        int bubble = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = bubble;

                        swap = true;

                    }
                }

                // Si swap es false, sale del bucle, ya que el array esta ordenado.
                if(!swap){
                    break;
                }
            }

            return array;
        }


    }
}
