using System;
using System.Collections.Generic;

/// <summary>
/// Dynamic connectivity algorithms
/// </summary>
/// <param name="args"></param>
namespace DynamicConnectivity
{
    class Program
    {
        /// <summary>
        /// DS to hold test data
        /// </summary>
        struct connectedItems
        {
            public int p;
            public int q;
        }

        /*
         * 10
         * 4 3
         * 3 8
         * 6 5
         * 9 4
         * 2 1
         * --8 9
         * 5 0
         * 7 2
         * 6 1
         * --1 0
         * --6 7
         * 7 3
         */
        static void Main(string[] args)
        {
            const int N = 10;
            List<connectedItems> items = new List<connectedItems> {
                new connectedItems{p=4,q=3 },
                new connectedItems{p=3,q=8 },
                new connectedItems{p=6,q=5 },
                new connectedItems{p=9,q=4 },
                new connectedItems{p=2,q=1 },
                new connectedItems{p=8,q=9 },
                new connectedItems{p=5,q=0 },
                new connectedItems{p=7,q=2 },
                new connectedItems{p=6,q=1 },
                new connectedItems{p=7,q=3 },
            };

            #region -- Quick find
            //QuickFindUF qfuf = new QuickFindUF(N);
            //foreach (var item in items)
            //{
            //    if (!qfuf.Connected(item.p, item.q))
            //    {
            //        qfuf.Union(item.p, item.q);
            //        Console.WriteLine(item.p + "   " + item.q);
            //    }
            //}
            #endregion

            #region -- Quick union
            //QuickUnionUF quuf = new QuickUnionUF(N);
            //foreach (var item in items)
            //{
            //    if (!quuf.Connected(item.p, item.q))
            //    {
            //        quuf.Union(item.p, item.q);
            //        Console.WriteLine(item.p + "   " + item.q);
            //    }
            //}
            #endregion

            #region -- Quick weighted union
            WeightedQuickUnionUF wquuf = new WeightedQuickUnionUF(N);
            foreach (var item in items)
            {
                if (!wquuf.Connected(item.p, item.q))
                {
                    wquuf.Union(item.p, item.q);
                    Console.WriteLine(item.p + "   " + item.q);
                }
            }
            Console.WriteLine(wquuf.Connected(8, 9));
            #endregion

            Console.Read();
        }
    }
}
