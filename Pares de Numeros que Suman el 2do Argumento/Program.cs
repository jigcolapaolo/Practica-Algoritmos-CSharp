namespace Pares_de_Numeros_que_Suman_el_2do_Argumento;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("El resultado es " + ParesSumanVar([0, 0, 0, 0, 1, 1], 1));

        static int ParesSumanVar(int[] arr, int total){

            // Uso una lista en vez de un array para poder agregar los indices luego.
            List<int> IndicesUsados = new List<int>();
            int SumaIndices = 0;

            for(int i = 0; i < arr.Length - 1; i++){
                for(int j = i + 1; j < arr.Length; j++){

                    // Si la lista no contiene los mismos indices actuales y la suma del contenido de ambos suma 
                    // el total, entra.
                    if(!IndicesUsados.Contains(i) && !IndicesUsados.Contains(j) && arr[i] + arr[j] == total){

                        IndicesUsados.Add(i);
                        IndicesUsados.Add(j);
                        SumaIndices += i + j;

                        // Sale del bucle para cambiar de indice, ya que acaba de ser usado.
                        break;

                    }
                }
            }
            return SumaIndices;
        }
    }
}
