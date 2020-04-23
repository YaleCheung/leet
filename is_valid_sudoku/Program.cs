using System;
using System.Collections.Generic;
namespace is_valid_sudoku
{
    class Program
    {
        private bool[] _hash;
        public void ResetHash() {
            for(var i = 0; i < 10; ++ i) 
                _hash[i] = false;
        }
        public Program() {
            _hash = new bool[10];
            ResetHash();
        }
        public bool IsValidSudoku(char[][] board) {
            // check rows
            for(var i = 0; i < 9; ++ i) {
                ResetHash();
                for(var j = 0; j < 9; ++ j) {
                    if (! _CheckValid(board[i][j]))
                        return false;
                }
            }
            // check col
            for(var j = 0; j < 9; ++ j) {
                ResetHash();
                for(var i = 0; i < 9; ++ i) {
                    if (! _CheckValid(board[i][j]))
                        return false;
                }
            }
            // check subbox
            for(var i = 0; i < 9; i += 3) {
                for(var j = 0; j < 9; j += 3) {
                    ResetHash();
                    var row_order = i;
                    var col_order = j;
                    for(var k = 0; k < 9; ++ k) {
                        if (k != 0 
                        && (k % 3 == 0)) 
                            ++ row_order;
                        col_order = j + k % 3;
                        if (! _CheckValid(board[row_order][col_order])){
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool _CheckValid(char ele) {
            if (ele == '.') 
                return true;
            else if ((ele - '0') <= 0 
                  || (ele - '0') > 9)
                return false;
            else if (_hash[ele - '0'] == false) {
                _hash[ele - '0'] = true;
                return true; 
            } else
                return false;
        }

        static void Main (string[] args) {
            var program = new Program();
            char[][] input = 
            {
                new char[] {'.','.','.','.','5','.','.','1','.'},
                new char[] {'.','4','.','3','.','.','.','.','.'},
                new char[] {'.','.','.','.','.','3','.','.','1'},
                new char[] {'8','.','.','.','.','.','.','2','.'},
                new char[] {'.','.','2','.','7','.','.','.','.'},
                new char[] {'.','1','5','.','.','.','.','.','.'},
                new char[] {'.','.','.','.','.','2','.','.','.'},
                new char[] {'.','2','.','9','.','.','.','.','.'},
                new char[] {'.','.','4','.','.','.','.','.','.'}
            };
            program.IsValidSudoku(input);
        }
 
    }
}
