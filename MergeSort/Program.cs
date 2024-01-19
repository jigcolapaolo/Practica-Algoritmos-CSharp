namespace MergeSort;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {3,6,2,8};


        // Muestro cada elemento del array separado por ,
        Console.WriteLine(string.Join(", ", mergeSort(array)));



        static int[] mergeSort(int[] array){

            void merge(ref int[] array, int[] array1, int[] array2){

                // Declaro una nueva lista para que pueda recibir elementos de forma dinamica y luego
                // copiarla en el array por referencia
                List<int> arrayOrdenado = new List<int>();
                int i = 0;
                int j = 0;

                // Mientras ambos arrays tengan elementos para ser comparados, ingresara, empezara a 
                // comparar cual es el menor y agregandolo a la lista
                while(i < array1.Length && j < array2.Length){

                    if(array1[i] > array2[j]) arrayOrdenado.Add(array2[j++]);
                    else arrayOrdenado.Add(array1[i++]);
                    
                }

                // La lista que haya quedado con elementos sin agregar al arrayOrdenado, entrara a su
                // respectivo while y agregara a la lista, los elementos restantes que ya estan ordenados.
                while(i < array1.Length) arrayOrdenado.Add(array1[i++]);
                while(j < array2.Length) arrayOrdenado.Add(array2[j++]);

                // Se copian los elementos de arrayOrdenado en el ref array, sobreescribiendo.
                // El ref array siempre tendra la misma cantidad de elementos del arrayOrdenado
                arrayOrdenado.CopyTo(array);
            }



            if(array.Length == 1){
                return array;
            }

            // No es necesario usar math.floor ya que en C#, al ser tipo de dato int, 
            // redondeara hacia abajo
            int iMitad = array.Length / 2;

            // AsSpan(inicio, finalNoInclusive), para obtener un array desde inicio hasta finalNoInclusive
            int[] left = mergeSort(array.AsSpan(0, iMitad).ToArray());
            int[] right = mergeSort(array.AsSpan(iMitad).ToArray());

            // Se le envia el array original por referencia
            // (En cada recursion, el ref array se hara mas chico)
            //  y los subarrays para formar uno ordenado
            merge(ref array, left, right);

            return array;
        }
    }
}
