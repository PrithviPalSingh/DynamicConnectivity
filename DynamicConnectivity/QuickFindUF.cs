using System;
/// <summary>
/// Quick find algorithm
/// Too slow for huge problems 
/// This is called an Eager approach
/// Trees are flat but keeping them flat is too expensive
/// </summary>
namespace DynamicConnectivity
{
    class QuickFindUF
    {
        private int[] array;

        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="N"></param>
        public QuickFindUF(int N)
        {
            array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i;
            }
        }

        /// <summary>
        /// O(1)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            return array[p] == array[q];
        }

        /// <summary>
        /// O(N) for single union command
        /// If there is a union of N objects this will take Quadratic time
        /// Quadratic algorithms don't scale with technology
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            int pid = array[p];
            int qid = array[q];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == pid)
                {
                    array[i] = qid;
                }
            }
        }
    }
}
