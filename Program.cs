
using System;
using System.Collections.Generic;

namespace Test22
{
    class Program
    {
        static void Main(string[] args)
        {
            Oscar oscar1 = new Oscar();
            Oscar oscar2 = new Oscar();
            GoldenGlobe goldenglobe1 = new GoldenGlobe();
            GoldenGlobe goldenglobe2 = new GoldenGlobe();

            Stack<Oscar> aStackOfOscars = new Stack<Oscar>();
            Stack<GoldenGlobe> aStackOfGoldenGlobes = new Stack<GoldenGlobe>();

            aStackOfOscars.Push(oscar1);
            aStackOfOscars.Push(oscar2);
            aStackOfGoldenGlobes.Push(goldenglobe1);
            aStackOfGoldenGlobes.Push(goldenglobe2);

            foreach (var i in aStackOfOscars)
            {
                Console.WriteLine(i.DisplayAward().ToString());
            }

            foreach (var i in aStackOfGoldenGlobes)
            {
                Console.WriteLine(i.DisplayAward().ToString());
            }

            Console.ReadLine();

        }
    }
}
