using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Arrays
{
    //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    class ArrayContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Hashtable hash = new Hashtable();

            foreach (var item in nums)
                if (hash.Contains(item))
                    return true;
                else
                    hash.Add(item, null);

            return false;
        }
    }
}
