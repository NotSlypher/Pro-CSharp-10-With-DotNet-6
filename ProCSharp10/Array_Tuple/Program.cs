namespace Array_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Indices and Ranges
            Console.WriteLine("Elements from the front");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Index idx = i;
                Console.WriteLine(gothicBands[idx]);
            }


            // Get the last element
            Console.WriteLine("Elements from the last");
            for(int i = 1; i <= gothicBands.Length; i++)
            {
                Index idx = ^i;
                Console.WriteLine(gothicBands[idx]);
            }

            // Slicing
            Console.WriteLine("Slicing");
            Range range = 1..3;
            for(int i = 0; i < gothicBands[range].Length; i++)
            {
                Console.WriteLine(gothicBands[range][i]);
            }
        }
    }
}
