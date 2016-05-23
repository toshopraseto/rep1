using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati_Lock
{
    class Illuminati_Lock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n + 1;
            int width = 3 * n;

            Console.WriteLine("{0}{1}{0}",
                new string('.',n), new string('#', n), new string('.', n));
            //
            int outer_up = n - 2;
            int inner_up = 0;
            int middle = outer_up;
            for (int i = 0; i < n / 2; i++)
            { 
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', outer_up),
                    new string('.', inner_up), new string('.', middle), new string('.', inner_up), new string('.', outer_up));
                outer_up -= 2;
                inner_up += 2;
            }
            //
            int outer_down = 1;
            int inner_down = n - 3;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', outer_down),
                    new string('.', inner_down), new string('.', middle), new string('.', inner_down), new string('.', outer_down));
                outer_down += 2;
                inner_down -= 2;
            }
            //
            Console.WriteLine("{0}{1}{0}",
               new string('.', n), new string('#', n), new string('.', n));

        }
    }
}
