using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicConnectivity
{
    class WeightedQuickUnionUF
    {
        private int[] array;
        private int[] weight;

        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="N"></param>
        public WeightedQuickUnionUF(int N)
        {
            array = new int[N];
            weight = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i;
                weight[i] = i;
            }
        }
        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int root(int num)
        {
            while (num != array[num])
            {
                // This line is for path compression
                //array[num] = array[array[num]];

                num = array[num];
            }

            return array[num];
        }

        /// <summary>
        /// O(lg(N))
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            return root(p) == root(q);
        }

        /// <summary>
        /// O(lg(N))
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            int pid = root(p);
            int qid = root(q);

            if (weight[pid] < weight[qid])
            {
                array[pid] = qid;
                weight[qid] += weight[pid];
            }
            else
            {
                array[qid] = pid;
                weight[pid] += weight[qid];
            }
        }
    }
}

