package io.isoftware.app;

public class LongestCommonPrefix {
    public String longestCommonPrefix(String[] strs) {

        if(strs.length==0){
            return "";
        }

        String prefix = strs[0];

        for(int index=1; index< strs.length; index++){


            while(strs[index].indexOf(prefix)!=0){
                prefix = prefix.substring(0, prefix.length()-1);
                if(prefix.isEmpty())
                    return "";
            }


        }

        return prefix;
    }
}
