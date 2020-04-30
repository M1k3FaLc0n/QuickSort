using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class QuickSort
    {
        private static int partition(List<ListItem> array, int start, int end)
        {
            ListItem tmp;
            ListItem pivot = array[end];
            int small = start;
            for(int i = start; i < end; i++)
            {
                if (String.Compare(array[i].Name,pivot.Name,StringComparison.CurrentCultureIgnoreCase) < 0)
                {
                    tmp = array[i];
                    array[i] = array[small];
                    array[small] = tmp;
                    small++;
                }
            }

            tmp = array[end];
            array[end] = array[small];
            array[small] = tmp;

            return small;
        }

        private static void quick_sort_helper(List<ListItem> array, int start, int end)
        {
            if(start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quick_sort_helper(array, start, pivot - 1);
            quick_sort_helper(array, pivot + 1, end);
                    }

        public static void quick_sort(List<ListItem> array)
        {
            quick_sort_helper(array,0,array.Count - 1);
        }
    }
}
