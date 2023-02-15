public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string longestCommonPrefix = "";

        if(strs[0].Length > 0)
        {
            longestCommonPrefix = strs[0];
        }

        foreach(var s in strs)
        {
            var stringLength = s.Length;

            if(stringLength > longestCommonPrefix.Length)
            {
                stringLength = longestCommonPrefix.Length;
            }

            if(s.Length == 0)
            {
                longestCommonPrefix = "";
                break;
            }

            for(var i = 0; i < stringLength; i++)
            {
                if(s[i] != longestCommonPrefix[i])
                {
                    longestCommonPrefix = s.Substring(0, i);
                    break;
                }

                if(i == stringLength - 1)
                {
                    longestCommonPrefix = s.Substring(0, stringLength);
                    break;
                }
            }
        }


        return longestCommonPrefix;
        
    }
}