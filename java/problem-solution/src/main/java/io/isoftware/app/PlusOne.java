package io.isoftware.app;

import java.util.ArrayList;

public class PlusOne {
    public static int[] plusOne(int[] digits) {

        ArrayList<Integer> result = new ArrayList<>();

        if(digits.length == 1){
            if(digits[0]<9){
                result.add(digits[0]+1);
            }else {
                result.add(1);
                result.add(0);
            }
        }else if (digits.length > 1){
            int carry = 0;
            int currentSum = 0;

            for(int index=digits.length-1; index>=0; index--){

                if(index==digits.length-1){
                    currentSum = digits[index] + 1;
                }else{
                    currentSum = digits[index] + carry;
                    carry = 0;
                }

                if(currentSum==10){
                    currentSum = 0;
                    carry = 1;
                }

                result.add(0, currentSum);
                currentSum = 0;
            }// end for

            if(carry==1){
                result.add(0, carry);
            }
        }


        return result.stream().mapToInt(num -> num).toArray();
    }
}
