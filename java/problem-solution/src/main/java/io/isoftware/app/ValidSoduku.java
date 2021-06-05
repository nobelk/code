package io.isoftware.app;

import java.util.HashMap;

public class ValidSoduku {

    public static boolean isValidSudoku(char[][] board) {

        HashMap<Character, Integer> square = new HashMap<>();

        // check each row
        for (int row = 0; row < 9; row++) {
            square.clear();
            for (int column = 0; column < 9; column++) {
                if (square.containsKey(board[row][column])) {
                    return false;
                } else {
                    if (board[row][column] != '.') {
                        square.put(board[row][column], 1);
                    }
                }
            }
        }

        // check each column
        for (int column = 0; column < 9; column++) {
            square.clear();
            for (int row = 0; row < 9; row++) {
                if (square.containsKey(board[row][column])) {
                    return false;
                } else {
                    if (board[row][column] != '.') {
                        square.put(board[row][column], 1);
                    }
                }
            }
        }


        // check sub-boxes
        for (int row = 0; row < 9; row += 3) {
            for (int column = 0; column < 9; column += 3) {
                square.clear();

                for (int rowAdder = 0; rowAdder < 3; rowAdder++) {
                    for (int columnAdder = 0; columnAdder < 3; columnAdder++) {

                        if (square.containsKey(board[row + rowAdder][column + columnAdder])) {
                            return false;
                        } else {
                            if (board[row + rowAdder][column + columnAdder] != '.') {
                                square.put(board[row + rowAdder][column + columnAdder], 1);
                            }
                        }
                    }
                }// end of sub-square for
            }
        }

        return true;
    }


    public static boolean containsAllNumbers(HashMap<Character, Integer> square) {

        char[] numbers = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

        for (char number : numbers) {
            if (!square.containsKey(number)) {
                return false;
            }
        }

        return true;
    }

}
