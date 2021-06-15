package io.isoftware.app;

import java.util.HashMap;

public class ValidAnagram {
    public boolean isAnagram(String s, String t) {

        if(s.length() != t.length()){
            return false;
        }

        HashMap<Character, Integer> tmpMap = new HashMap<>(s.length());

        for(int index = 0; index<s.length(); index++){
            if(tmpMap.containsKey(s.charAt(index))){
                tmpMap.put(s.charAt(index), tmpMap.get(s.charAt(index))+1);
            }else {
                tmpMap.put(s.charAt(index), 1);
            }
        }

        for(int index = 0; index<t.length(); index++){
            if(tmpMap.containsKey(t.charAt(index))){
                tmpMap.put(t.charAt(index), tmpMap.get(t.charAt(index))-1);
            }
        }

        for(Integer val: tmpMap.values()){
            if(val!=0){
                return false;
            }
        }

        return true;
    }
}
