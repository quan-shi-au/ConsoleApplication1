using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BitCalculation
    {
        /*
         *  Let's assume a twos-complement number (as it's the usual case and you don't say otherwise) and let's assume 32-bit:

First, we perform an arithmetic right-shift by 31 bits. This shifts in all 1s for a negative number or all  0s for a positive one (but note that the actual >>-operator's behaviour in C or C++ is implementation defined for negative numbers, but will usually also perform an arithmetic shift, but let's just assume pseudocode or actual hardware instructions, since it sounds like homework anyway):

mask = x >> 31;
So what we get is 111...111 (-1) for negative numbers and 000...000 (0) for positives

Now we XOR this with x, getting the behaviour of a NOT for mask=111...111 (negative) and a no-op for mask=000...000 (positive):

x = x XOR mask;
And finally subtract our mask, which means +1 for negatives and +0/no-op for positives:

x = x - mask;
So for positives we perform an XOR with 0 and a subtraction of 0 and thus get the same number. And for negatives, we got (NOT x) + 1, which is exactly -x when using twos-complement representation.
         *  
         *  
         */
        public static void PrintOperator()
        {
            var a = 1 ^ 2; // XOR
            var b = ~(1 ^ 2);   // XNOR

            Console.WriteLine("1 XOR 2 is {0:x}", 1 ^ 2);
            Console.WriteLine("1 XNOR 2 is {0:x}", ~(1 ^ 2));


            Console.WriteLine("-1: 0x{0:x}", -1);
            Console.WriteLine("3: 0x{0:x}", 3);
            Console.WriteLine("3: 0x{0:x}", 1 ^ 2);
        }


        public static int Abs(int num)
        {

            Console.WriteLine("1: 0x{0:x}", 1);
            Console.WriteLine("1 << 1: 0x{0:x}", 1 << 1);
            Console.WriteLine("1 << 2: 0x{0:x}", 1 << 2);
            Console.WriteLine("1 << 3: 0x{0:x}", 1 << 3);


            Console.WriteLine("-1: 0x{0:x}", -1);
            Console.WriteLine("-1 << 1: 0x{0:x}", -1 << 1);
            Console.WriteLine("-1 << 2: 0x{0:x}", -1 << 2);
            Console.WriteLine("-1 << 3: 0x{0:x}", -1 << 3);


            Console.WriteLine("1: 0x{0:x}", 1);
            Console.WriteLine("1 >> 1: 0x{0:x}", 1 >> 1);
            Console.WriteLine("1 >> 2: 0x{0:x}", 1 >> 2);
            Console.WriteLine("1 >> 3: 0x{0:x}", 1 >> 3);

            // The point is that the C >> (right shift) operator preserves1 the sign for a (signed) int
            Console.WriteLine("-1: 0x{0:x}", -1);
            Console.WriteLine("-1 >> 1: 0x{0:x}", -1 >> 1);
            Console.WriteLine("-1 >> 2: 0x{0:x}", -1 >> 2);
            Console.WriteLine("-1 >> 3: 0x{0:x}", -1 >> 3);


            Console.WriteLine("-1: 0x{0:x}", -1);
            Console.WriteLine("-1 >> 31: 0x{0:x}", -1 >> 31);
            Console.WriteLine("-2 >> 31: 0x{0:x}", -2 >> 31);
            Console.WriteLine("-3 >> 31: 0x{0:x}", -3 >> 31);


            Console.WriteLine("0x{0:x}", num);

            int m = num >> 31;

            Console.WriteLine("0x{0:x}", m);

            var y = (num + m) ^ m;

            Console.WriteLine("0x{0:x}", y);

            return y;
        }
    }
}
