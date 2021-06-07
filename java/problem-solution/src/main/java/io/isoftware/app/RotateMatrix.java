package io.isoftware.app;

public class RotateMatrix {

    public void rotate(int[][] matrix) {

        int n= matrix.length;

        // transpose
        for(int row=0; row<n; row++){
            for(int column=row; column<n; column++){
                int tmp = matrix[row][column];
                matrix[row][column] = matrix[column][row];
                matrix[column][row] = tmp;
            }
        }

        /// reflect around middle column
        for(int row=0; row<n; row++){
            for(int column=0; column<n/2; column++){
                int tmp = matrix[row][column];
                matrix[row][column] = matrix[row][n-column-1];
                matrix[row][n-column-1] = tmp;
            }
        }
    }
}
