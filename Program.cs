namespace ejercicio3rep
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Linea:");
            int linea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Texto:");
            string texto = Console.ReadLine();

            StreamWriter sw;
            sw = File.CreateText("archivo.txt");



        }
    }
}