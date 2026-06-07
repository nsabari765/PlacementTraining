public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> rti = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;

        for (int i = 0; i < s.Length - 1; i++){
            int charAt = rti[s[i]];
            int nextCharAt = rti[s[i + 1]];

            if (charAt < nextCharAt){
                result -= charAt;
            }
            else{
                result += charAt;
            }
        }

        return result + rti[s[s.Length - 1]];
    }
}