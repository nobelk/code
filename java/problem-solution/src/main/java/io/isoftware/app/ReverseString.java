package io.isoftware.app;

public class ReverseString {
    public void reverseString(char[] s) {
        if(s==null || s.length<=1){
            return;
        }
        for(int index=0; index<s.length/2; index++){
            char tmp = s[index];
            s[index] = s[s.length-1-index];
            s[s.length-1-index] = tmp;
        }
    }
}
