package ticTacToe;

import javax.swing.*;
import java.util.Arrays;
import java.util.Random;

public class main {
    public static boolean running = true, over = false;
    public static boolean[][] boardCheck = new boolean[3][3];
    public static int[][] board = {
            {0,0,0},
            {0,0,0},
            {0,0,0}
    };
    public static String[][] boardShow = {
            {"1","2","3"},
            {"4","5","6"},
            {"7", "8","9"}
    };
    public static int col, row;

    public static void main(String[] args){
        JOptionPane.showMessageDialog(null, "Welcome to Tic Tac Toe \n You will have X and the computer will have O's", "Welcome", JOptionPane.OK_OPTION);
        while(running){
            newNumAI();
            createNum();
        }
    }

    private static void winCheck(){
        JOptionPane.showMessageDialog(null, "game Done");
    }

    private static void newNumAI(){
        boolean rerun = true;
        while(rerun){
            Random rand = new Random();
            row = rand.nextInt(3);
            col = rand.nextInt(3);
            if(board[row][col] == 0) {
                boardShow[row][col] = "O";
                board[row][col] = 2;
                if(isWinner(row,col)){
                    JOptionPane.showMessageDialog(null,"The computer won");
                    running = false;
                    System.exit(100);
                }
                else
                rerun = false;
            }
        }
    }

    private static void createNum() {
        boolean rerun = true;
        while(rerun){
            String output = "";
            for (int x = 0; x < 3; x++) {
                for (int y = 0; y < 3; y++) {
                    output += boardShow[x][y] + " ";
                }
                output += "\n";
            }

            int input = Integer.parseInt(JOptionPane.showInputDialog(null, "Select a number to play \n" + output));
            row = (input - 1) / 3;
            col = (input - 1) % 3;

            if (input == 1) {
                row = 0;
                col = 0;
            }
            if(board[row][col] == 0){
                board[row][col] = 1;
                rerun = false;
            }
            else{
                JOptionPane.showMessageDialog(null, "Position already taken, choose another!", "error", JOptionPane.ERROR_MESSAGE);
            }
        }
        if(board[row][col] == 1){
            boardShow[row][col] = "X";
            if(isWinner(row,col)){
                JOptionPane.showMessageDialog(null,"You won");
                running = false;
                System.exit(100);
            }
        }
    }

    public static boolean isWinner(int row, int col){
        String Player = boardShow[row][col];

        int r = row;
        int c = col;

        boolean onDiagonal = (row == col) || (col == -1 * row + (board.length-1));
        boolean HorizontalWin = true, VerticalWin = true;
        boolean DiagonalWinOne = true, DiagonalWinTwo = true;

        // Check the rows and columns
        for(int n = 0; n < board.length; n++){
            if(!boardShow[r][n].equals(Player))
                HorizontalWin = false;
            if(!boardShow[n][c].equals(Player))
                VerticalWin = false;
        }

        // Only check diagonals if the move is on a diagonal
        if(onDiagonal){
            // Check the diagonals
            for(int n = 0; n < board.length; n++){
                if(!boardShow[n][n].equals(Player))
                    DiagonalWinOne = false;
                if(!boardShow[n][-1*n+(boardShow.length-1)].equals(Player))
                    DiagonalWinTwo = false;
            }
        }
        else{
            DiagonalWinOne = false;
            DiagonalWinTwo = false;
        }

        boolean hasWon = (HorizontalWin || VerticalWin || DiagonalWinOne || DiagonalWinTwo);
        return hasWon;
    }
}
