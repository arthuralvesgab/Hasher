using System;

class Program
{
    static void verificarHashes(string entrada)
    {
        string[] pares = entrada.Split( ';' );
        
        foreach (string par in pares)
        {
            // Divide cada par pelo ,
            string[] hashes = par.Split(',');

             // Remove espaços extras
             string hashCalculado = hashes[0].Trim();
             string hashEsperado = hashes[1].Trim();

             // Compara os hashes
             if(hashCalculado == hashEsperado)
            {
                Console.WriteLine("Correto");
            }
            else
            {
                Console.WriteLine("Invalido");
            }
        }  
    }
    static void Main(string[] argas)
    {
        string entrada = Console.ReadLine() ?? "";

        verificarHashes(entrada);
    }
}