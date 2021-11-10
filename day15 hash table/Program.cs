using System;

namespace day15_hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
           // UC1

            UC1_line_frequency hash1 = new UC1_line_frequency();
            hash1.Freq();

            //UC2

            UC2_large_para hash2 = new UC2_large_para();
            hash2.FreqLarge();

            //UC3

            UC3_Remove hash3 = new UC3_Remove();
            hash3.removeWord("");
        }
    }
    }

