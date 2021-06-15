package io.isoftware.app;

import java.util.HashMap;

public class FirstNonRepeatingChar {
    public int firstUniqChar(String s) {

        int charIndex = -1;

        if(s==null){
            return charIndex;
        }
        else if (s.length()==1){
            return 0;
        }

        HashMap<Character, Integer> tmpMap = new HashMap<>(s.length());

        for(int index = 0; index<s.length(); index++){
            if(tmpMap.containsKey(s.charAt(index))){
                tmpMap.put(s.charAt(index), tmpMap.get(s.charAt(index))+1);
            }else {
                tmpMap.put(s.charAt(index), 1);
            }
        }

        for(int index = 0; index<s.length(); index++){
            if(tmpMap.get(s.charAt(index))==1){
                charIndex = index;
                break;
            }
        }

        return charIndex;
    }
}
