public class Solution {
    public bool CanJump(int[] nums) {
        int stand = nums[0];
        int jump = nums[0];
        int i = 0;
        bool isDestinationReached = nums.Length == 1;

        for (i = 1; i < nums.Length; i++)
        {
            if (jump != 0)
            {
                jump--;

                stand = i;
                isDestinationReached = stand == nums.Length - 1;

                if (jump == 0 || jump < nums[i])
                {
                    jump = i == nums.Length - 1 ? 0 : nums[i];
                }
            }
        }

        return isDestinationReached;
    }
}