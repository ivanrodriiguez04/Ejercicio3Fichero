namespace Ejercicio3Fichero 
{
    /// <summary>
    /// Clase princicpal de la aplicacion
    /// irodhan -> 19/03/2024
    /// </summary>
    class Program 
    { 
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 19/03/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            string fichero = "C:\\Users\\csi22-irodhan\\Desktop\\ficheroPrueba.txt";


            try
            {
                Console.WriteLine("En que linea deseas escribir: ");
                int numeroLinea = Convert.ToInt32(Console.ReadLine());
                

                string[] lineas=File.ReadAllLines(fichero);
                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {
                    Console.WriteLine("Que desea escribir: ");
                    string nuevoTexto = Console.ReadLine();

                    lineas[numeroLinea - 1] = nuevoTexto;

                    File.WriteAllLines(fichero, lineas);
                }
                else 
                {
                    Console.WriteLine("La linea en la que desea escribir esta fuera de rango");
                }
            }
            catch (IOException e) 
            { 
                Console.WriteLine("Error al leer o escribir en el archivo: "+e.Message);
            }
        }
    }
}
