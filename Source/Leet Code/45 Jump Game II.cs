public class Solution {
    public int Jump(int[] nums) {
        int maxReachable = 0, currentJumpEnd = 0, jumps = 0;
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            maxReachable = Math.Max(maxReachable, i + nums[i]);
            
            if(i == currentJumpEnd)
            {
                jumps++;
                
                currentJumpEnd = maxReachable;
            }
        }
        
        return jumps;
    }
}