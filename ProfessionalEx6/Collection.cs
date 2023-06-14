using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx6
{
    class Collection
    {
        List<int> ints;

        public void Method(params int[] array)
        {
            ints = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    ints.Add(array[i]);
                }
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            foreach(int i in ints)
            yield return (int)Math.Pow(i, 2);
        }


    }
}
