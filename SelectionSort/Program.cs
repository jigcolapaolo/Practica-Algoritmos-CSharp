namespace SelectionSort;

class Program
{
    static void Main(string[] args)
    {

        int[] arrayOrdenado = selectionSort(new int[]{5,2,7});

	for(int i = 0; i < arrayOrdenado.Length; i++){

            if(i == arrayOrdenado.Length - 1)
                Console.Write(arrayOrdenado[i]);
            else
                Console.Write(arrayOrdenado[i] + ", ");
            
        }

        static int[] selectionSort(int[] arr){

            // array.length - 1 porque el ultimo elemento no tiene con quien compararse.
            for(int i = 0; i < arr.Length - 1; i++){

                // Guardo el primer elemento del indice actual y el indice tambien.
                int menor = arr[i];
                int indiceMinimo = i;

                for(int j = i; j < arr.Length; j++){

                    // En caso de encontrar un elemento menor, se guardara junto con su indice.
                    if(arr[j] < menor){

                        menor = arr[j];
                        indiceMinimo = j;
                    }
                }

                // Al terminar, intercambio elementos, el numero menor se intercambiara con el numero del elemento
                // en el indice en i.
                int bubble = arr[i];
                arr[i] = arr[indiceMinimo];
                arr[indiceMinimo] = bubble;
            }

            return arr;
        }


    }
}
