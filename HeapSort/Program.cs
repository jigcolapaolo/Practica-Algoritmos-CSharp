namespace HeapSort;

class Program
{
    static void Main(string[] args)
    {
        // Solo esta debe ser declarada static, para que pueda tener en cuenta el count en las demas funciones
        static int permSinRep(string str){

            char[] arr = str.ToArray();
            int count = 0;

            generarPermutacion(arr, arr.Length);


            // Función auxiliar para verificar si hay letras consecutivas repetidas en una permutación
            bool hayRepetidos(char[] arr){

                for(int i=0; i < arr.Length - 1; i++){
                    
                    if(arr[i] == arr[i + 1])
                    return true;
                }

                return false;
            }

            // Función auxiliar para intercambiar elementos en un array
            void swap(char[]arr, int i, int j){

                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

            }

            // Función recursiva para generar permutaciones
            void generarPermutacion(char[] arr, int n){
                
                // Seguira de largo a generatePermutations hasta que la longitud del array sea 1
                if(n == 1){
                    if (!hayRepetidos(arr)){
                        count++;
                    }

                    return;
                }

                for(int i=0; i < n; i++){
                    //Función recursiva, ingresara varias veces hasta haber generado todas las permutaciones posibles
                    generarPermutacion(arr, n - 1);
                    if(n % 2 == 0)
                        swap(arr, i, n - 1);
                    else
                        swap(arr, 0, n - 1);

                }
            }


            return count;
        }

        int resultado = permSinRep("aabb");

        Console.WriteLine("El resultado es " + resultado);
    }
}
