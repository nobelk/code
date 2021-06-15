package io.isoftware.app;

public class ValidPalindrome {
    public boolean isPalindrome(String s) {
        String candidate = s.replaceAll("\\p{Punct}", "");
        candidate = candidate.replaceAll("\\p{Blank}","");
        for(int index=0; index<candidate.length()/2; index++){
            if(Character.toLowerCase(candidate.charAt(index)) != Character.toLowerCase(candidate.charAt(candidate.length()-1-index))){
                return false;
            }
        }
        return true;
    }
}
