package io.isoftware.app;

public class NeedleInHaystack {

    public int findNeedleInHaystack(String haystack, String needle){

        if(needle.isEmpty()){
            return 0;
        }

        if(haystack.isEmpty()){
            return -1;
        }

        if(needle.length()==1 && haystack.length()==1){
            if(needle.charAt(0)==haystack.charAt(0)){
                return 0;
            }else{
                return -1;
            }
        }

        for(int index=0; index<=haystack.length()-needle.length(); index++){
            if(haystack.substring(index, index+needle.length()).equals(needle)){
                return index;
            }
        }

        return -1;
    }
}
