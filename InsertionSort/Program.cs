namespace InsertionSort;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayOrdenado = insertionSort(new int[]{7,3,5,2});

        // Se recorre el array ordenado para mostrarlo en pantalla.
        for(int i = 0; i < arrayOrdenado.Length; i++){

            if(i == arrayOrdenado.Length - 1)
                Console.Write(arrayOrdenado[i]);
            else
                Console.Write(arrayOrdenado[i] + ", ");
            
        }

        static int[] insertionSort(int[] arr){

            for(int i = 1; i < arr.Length; i++){

                // El indice 0 es el inicio del array ordenado, asi que se comienza toma el elemento de array[1]
                // para compararlo con el numero mas grande del array ordenado
                int bubble = arr[i];
                // El elemento actual se guarda en una burbuja
                int j;
                
                for(j = i - 1; j >= 0 && arr[j] > bubble; j--){
                    // Si es mas grande, ese numero se asigna al indice que le sigue, la primera iteracion
                    // sobreescribe el elemento actual que se guardo en la variable burbuja
                    arr[j+1] = arr[j];
                    //   Recorre el array hacia atras hasta que encuentre un numero menor o llegue al final.
                }

                // Durante las iteraciones del ciclo for, habran numeros duplicados. Cuando el ciclo termine,
                // se asigna el elemento actual en la variable burbuja en el indice de ultimo elemento duplicado.

                arr[j+1] = bubble;
            }

            return arr;
        }
    }
}
