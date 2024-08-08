



namespace UsingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SimpleArrays();
            //ArrayInitializations();
            //MultiDimentionalArrays();
            JaggedArray();
        }

        private static void JaggedArray()
        {
            Console.WriteLine("-> Jagged Array");
            int[][] jaggedArray = new int[3][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[i + 7];
                for (global::System.Int32 j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i + j;
                }
            }

            foreach (var item in jaggedArray)
            {
                foreach (var x in item)
                {
                    Console.Write(x + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }

        private static void MultiDimentionalArrays()
        {
            int[,] nums = new int[3,4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    nums[i,j] = i * j;
                }
            }

            for(int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    Console.Write(nums[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void ArrayInitializations()
        {
            Console.WriteLine("-> Array Initialization");
            string[] array = new string[10];                // with new keyword
            bool[] boolArray = {true, false};               // using {}
            int[] intArray2 = new int[4] { 1, 2, 3, 4 };    // same as second one
            var names = new string[] { "Raj", "Ram" };
        }

        /// <summary>
        /// this pretty much sums it up
        /// </summary>
        private static void SimpleArrays()
        {
            Console.WriteLine("-> Simple Array Creation.");
            int[] myInts = new int[3];
            myInts[0] = 1;
            myInts[1] = 2;  
            myInts[2] = 3;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }
    }
}
