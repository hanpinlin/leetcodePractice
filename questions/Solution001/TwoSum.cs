//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.
//Example 1:
//Input: nums = [2, 7, 11, 15], target = 9
//Output:[0,1]
//Output: Because nums[0] +nums[1] == 9, we return [0, 1].

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Solution001
{
    class TwoSum
    {
        public static int[] twoSum(int[] nums, int target) {
            
            Dictionary<int, int> hashTable = new Dictionary<int, int>();
            //如果我們被要求只能用 O(n) 複雜度的演算法解出這題要怎麼辦呢。一個方法就是用 Hash Table，做法是，
            //當迴圈跑到nums[i]時，如果 target-nums[i]還不在 Hash Table中，那就儲存(nums[i], i)，從題目的範例看一下:
            for (int i=0; i<nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashTable.ContainsKey(complement))
                {
                    return new int[] { hashTable[complement], i };
                }
                else
                {
                    hashTable[nums[i]] = i;
                }


                //THIS IS A WAY TO SOLOVE BUT TOO SLOW 
                //for (int j=i+1; j<nums.Length; j++)
                //{
                //    if(nums[i] +nums[j] == target)
                //    {
                //        return new int[] { i, j };
                //    }
                //}
            }
            throw new Exception("Not fund.");
         }  
     }
}
