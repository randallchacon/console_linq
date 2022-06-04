using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Miscellaneous
{
    public static class ChunkMiscellaneous
    {
        public static void Main()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var chunkNumbers = A.Chunk(2);

            foreach (var c in chunkNumbers) { 
                foreach(var nums in c)
                {
                    Console.Write(nums+" ");
                }    
                Console.WriteLine(" ");
            }; 
        }
    }
}
