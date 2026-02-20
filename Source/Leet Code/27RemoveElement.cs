public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int size = nums.Length;
        int length = 0;
        int isVal = 0;
        int ld = size - 1;
        
        if(size > 0 
            &&isVal != ld
            || (isVal == 0 
                && ld == 0
                && nums[isVal] != val))
        {
            while(isVal <= ld)
            {
                if(nums[ld] == val)
                {
                    nums[ld] = 51;
                    ld--;
                    
                    if(nums[isVal] != 51
                        && nums[isVal] != val)
                    {
                        isVal++;
                        length++;
                    }
                    
                    continue;
                }
                
                if(nums[isVal] == val)
                {
                    nums[isVal] = nums[ld];
                    length++;
                    nums[ld] = 51;
                    ld--;
                    isVal++;
                }
                else
                {
                    isVal++;
                    length++;
                }
            }
        }
        
        return length;
    }
}