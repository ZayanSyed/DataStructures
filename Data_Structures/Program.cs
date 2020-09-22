using System;

namespace Data_Structures
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stack a = new Stack(10);
            a.Pop();
            try
            {
                a.Pop();

            }
            catch { }
        }
    }
}
