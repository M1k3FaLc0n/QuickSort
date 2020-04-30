using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    static class BinarySearch
    {
        public static int binary_search(List<ListItem> array, String key)
        {
            int left = -1;
            int right = array.Count;
            while (left < right - 1)
            {
                int mid = (left + right) / 2;
                if(array[mid].Name.ToLower() == key.ToLower())
                {
                    return mid;
                }
                if(String.Compare(array[mid].Name,key,StringComparison.CurrentCultureIgnoreCase) < 0)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }

            }
            return -1;
        }
    }
}
