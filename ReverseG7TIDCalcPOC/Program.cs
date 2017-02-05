using System;

namespace ReverseG7TIDCalcPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter intended G7TID: ");
            int G7TID = 0;
            bool entryG7TID = false;
            bool validEntry = false;

            while (!entryG7TID || !validEntry)
            {
                entryG7TID = int.TryParse(Console.ReadLine(), out G7TID);
                if (G7TID >= 0 && G7TID <= 999999)
                {
                    validEntry = true;
                }

                if (!entryG7TID || !validEntry)
                {
                    Console.WriteLine("Invalid entry, try again.");
                }
            }

            int final, i_TID, i_SID;
            Random random = new Random();
            i_TID = random.Next(0, 65535);
            bool matchFound = false;

            while (!matchFound)
            {
                i_SID = 0;

                while (i_SID < 65535 && !matchFound)
                {
                    final = i_TID + (i_SID * 65536) % 1000000;

                    if (final == G7TID)
                    {
                        Console.WriteLine("TID: " + i_TID);
                        Console.WriteLine("SID: " + i_SID);
                        Console.WriteLine("G7TID: " + G7TID);
                        matchFound = true;
                        Console.WriteLine("Press ENTER to exit.");
                        Console.ReadLine();
                        return;
                    }

                    i_SID++;
                }

                i_TID = (i_TID == 65535) ? 0 : i_TID + 1;
            }
        }
    }
}
