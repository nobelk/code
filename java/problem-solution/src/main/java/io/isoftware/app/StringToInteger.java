package io.isoftware.app;

public class StringToInteger {
    public int ConvertToInteger(String s){
        int result = 0;

        if(s==null || s.length()==0){
            return result;
        }

        s = s.trim();

        if(s.length()==0){
            return 0;
        }

        int start=0, sign=1;
        if(s.charAt(0)=='-'){
            sign = -1;
            start++;
        }else if(s.charAt(0)=='+'){
            start++;
        }

        for(int index=start; index<s.length(); index++){
            if(!Character.isDigit(s.charAt(index))){
                return result * sign;
            }

            result = result * 10 + s.charAt(index) - '0';
            if (sign == 1 && result > Integer.MAX_VALUE)
                return Integer.MAX_VALUE;
            if (sign == -1 && (-1) * result < Integer.MIN_VALUE)
                return Integer.MIN_VALUE;
        }

        return result*sign;
    }
}
