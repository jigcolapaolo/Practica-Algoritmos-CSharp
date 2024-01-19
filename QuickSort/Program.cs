namespace QuickSort;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[]{4,3,2,6,7,4,2};
        int iMin = 0;
        int iMax = array.Length - 1;

        int[] arrayOrdenado = quickSort(array, iMin, iMax);

        // Recorro el array para mostrarlo en pantalla.
        for(int i = 0; i < arrayOrdenado.Length; i++){

            Console.Write(arrayOrdenado[i] + " ");
        }

        // Para el array base, se establece que el inicio de la cadena (iMin) esta en el indice 0 y el fin de
        // la misma (iMax) esta en el indice array.length-1
        // Este metodo es recursivo, toma un array, estableciendo donde esta el inicio(iMin) y el fin (iMax)
        // del mismo, los cuales se determinan teniendo en cuenta el indice de un elemento pivote 
        static int[] quickSort(int[] array, int iMin, int iMax){

            void swap(int[] array, int iSwap, int iMin){

                int temp = array[iSwap];
                array[iSwap] = array[iMin];
                array[iMin] = temp;
            }

            // La funcion ira dividiendo un array base en arrays mas pequeños, dejara de hacer recursiones
            // cuando llegue a un array de un solo elemento
            if(iMin < iMax){

                // El pivote siempre sera el ultimo elemento del array
                int pivot = array[iMax];
                int iSwap = iMin - 1;
                // Se declara un indice que inicia siempre con este valor e ira avanzando por el array, segun la
                // condicion del bucle.

                for(int i = iMin; i <= iMax; i++){
                    // Este indice recorre todo el array, de inicio a fin
  
                    // Si el elemento actual es menor o igual al pivote..
                    if(array[i] <= pivot){
                        iSwap++;

                        // Si el indice de intercambio es menor al indice del recorrido, hay que hacer un swap entre ambos
                        // El menor se pondra antes
                        if(iSwap < i){
                            swap(array, iSwap, i);
                        }
                    }
                }

                // Si el iSwap no llego al final de la cadena, quiere decir que el pivote cambio de lugar.
                // El pivote, si cambia de lugar, solo lo hace al final del bucle ya que es el ultimo elemento del
                // array, por eso...si cambio de lugar, se encontraria en el indice iSwap, si no, seguiria al final
                // del array
                int iPivot = iSwap < iMax ? iSwap : iMax;

                // Al saber donde se encuentra el indice del pivote, divido el array en 2 y uso el indice pivote
                // para determinar donde finalizara el array de la izquierda..
                quickSort(array, iMin, iPivot - 1);
                // ..y donde iniciara el array de la derecha.
                quickSort(array, iPivot + 1, iMax);
            }


            return array;
        }
    }
}
