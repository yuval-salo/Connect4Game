﻿using System;
using System.Collections.Generic;

namespace FourInARowLogic
{
    internal class Board
    {
        public int RowSize { get; private set; }
        public int ColSize { get; private set; }
        private readonly Cell[,] r_Board = null;

        internal class Cell
        {
            public int Row { get; private set; }
            public int Col { get; private set; }
            public char Sign { get; set; }
            public bool IsPartOfSeq { get; set; }

            public Cell(int i_Row, int i_Col)
            {
                Row = i_Row;
                Col = i_Col;
                Sign = ' ';
                IsPartOfSeq = false;
            }
        }

        public Board(int i_Rows, int i_Cols)
        {
            ColSize = i_Cols;
            RowSize = i_Rows;
            r_Board = new Cell[i_Rows, i_Cols];
            initBoard();
        }

        
        private void initBoard()
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize; j++)
                {
                    r_Board[i, j] = new Cell(i, j);
                }
            }
        }

        public void ClearBoard()
        {
            foreach(Cell cell in r_Board)
            {
                cell.Sign = ' ';
                cell.IsPartOfSeq = false;
            }
        }

        public void AddMove(int i_Col, char i_Sign, out int o_Row)
        {
            int row = RowSize;
            bool setDone = false;

            while (row > 0 && !setDone)
            {
                if (r_Board[row - 1, i_Col - 1].Sign != ' ')
                {
                    row--;
                }
                else
                {
                    SetCell(row - 1, i_Col - 1, i_Sign);
                    setDone = true;
                }
            }

            o_Row = row;
        }

        public void SetCell(int i_Row, int i_Col, char i_Sign)
        {
            this.r_Board[i_Row, i_Col].Sign = i_Sign;
        }

        public bool IsDraw()
        {
            bool isDraw = true;

            for (int i = 0; i < RowSize && isDraw; i++)
            {
                for (int j = 0; j < ColSize && isDraw; j++)
                {
                    if (this.r_Board[i, j].Sign == ' ')
                    {
                        isDraw = false;
                    }
                }
            }
            return isDraw;
        }

        public bool IsWinnerMove(int i_Row, int i_Col)
        {
            return isPartOf4InCol(i_Row, i_Col) || isPartOf4InRow(i_Row, i_Col)
                                                || isPartOf4InRightDiagonal(i_Row, i_Col)
                                                || isPartOf4InLeftDiagonal(i_Row, i_Col);
        }

        private bool isPartOf4InRow(int i_Row, int i_Col)
        {
            char lastSign = r_Board[i_Row - 1, i_Col - 1].Sign;
            int countSameSign = 1;
            
            r_Board[i_Row - 1, i_Col - 1].IsPartOfSeq = true;
            for (int i = i_Col - 1; i > 0; i--)
            {
                if (r_Board[i_Row - 1, i - 1].Sign != lastSign)
                {
                    break;
                }

                r_Board[i_Row - 1, i - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            for (int i = i_Col + 1; i <= ColSize; i++)
            {
                if (r_Board[i_Row - 1, i - 1].Sign != lastSign)
                {
                    break;
                }
                
                r_Board[i_Row - 1, i - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            if (countSameSign < 4)
            {
                foreach (Cell cell in r_Board)
                {
                    cell.IsPartOfSeq = false;
                }
            }

            return countSameSign >= 4;
        }

        private bool isPartOf4InCol(int i_Row, int i_Col)
        {
            char lastSign = r_Board[i_Row - 1, i_Col - 1].Sign;
            int countSameSign = 1;

            r_Board[i_Row - 1, i_Col - 1].IsPartOfSeq = true;
            for (int i = i_Row - 1; i > 0; i--)
            {
                if (this.r_Board[i - 1, i_Col - 1].Sign != lastSign)
                {
                    break;
                }

                r_Board[i - 1, i_Col - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            for (int i = i_Row + 1; i <= RowSize; i++)
            {
                if (this.r_Board[i - 1, i_Col - 1].Sign != lastSign)
                {
                    break;
                }

                r_Board[i - 1, i_Col - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            if (countSameSign < 4)
            {
                foreach (Cell cell in r_Board)
                {
                    cell.IsPartOfSeq = false;
                }
            }

            return countSameSign >= 4;
        }

        private bool isPartOf4InRightDiagonal(int i_Row, int i_Col)
        {
            char lastSign = r_Board[i_Row - 1, i_Col - 1].Sign;
            int countSameSign = 1;

            r_Board[i_Row - 1, i_Col - 1].IsPartOfSeq = true;
            for (int i = i_Row - 1, j = i_Col + 1; i > 0 && j <= ColSize; i--, j++)
            {
                if (r_Board[i - 1, j - 1].Sign != lastSign)
                {
                    break;
                }

                r_Board[i - 1, j - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            for (int i = i_Row + 1, j = i_Col - 1; i <= RowSize && j > 0; i++, j--)
            {
                if (r_Board[i - 1, j - 1].Sign != lastSign)
                {
                    break;
                }

                r_Board[i - 1, j - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            if (countSameSign < 4)
            {
                foreach (Cell cell in r_Board)
                {
                    cell.IsPartOfSeq = false;
                }
            }

            return countSameSign >= 4;
        }

        private bool isPartOf4InLeftDiagonal(int i_Row, int i_Col)
        {
            char lastSign = this.r_Board[i_Row - 1, i_Col - 1].Sign;
            int countSameSign = 1;

            r_Board[i_Row - 1, i_Col - 1].IsPartOfSeq = true;
            for (int i = i_Row - 1, j = i_Col - 1; i > 0 && j > 0; i--, j--)
            {
                if (r_Board[i - 1, j - 1].Sign != lastSign)
                {
                    break;
                }

                r_Board[i - 1, j - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            for (int i = i_Row + 1, j = i_Col + 1; i <= RowSize && j <= ColSize; i++, j++)
            {
                if (r_Board[i - 1, j - 1].Sign != lastSign)
                {
                    break;
                }

                r_Board[i - 1, j - 1].IsPartOfSeq = true;
                countSameSign++;
            }

            if(countSameSign < 4)
            {
                foreach(Cell cell in r_Board)
                {
                    cell.IsPartOfSeq = false;
                }
            }

            return countSameSign >= 4;
        }

        public int ScoreOfBoard()
        {
            int score = 0;

            score += this.checkRowsSequences();
            score += this.checkColsSequences();
            score += this.checkUpToDownDiagonalSequences();
            score += this.checkDownToUpDiagonalSequences();

            return score;
        }

        private int checkRowsSequences()
        {
            int score = 0;

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColSize - 3; j++)
                {
                    char[] seq = new char[4]
                                     {
                                         this.r_Board[i, j].Sign, this.r_Board[i, j + 1].Sign, this.r_Board[i, j + 2].Sign,
                                         this.r_Board[i, j + 3].Sign
                                     };
                    score += getSequenceScore(seq);
                }
            }

            return score;
        }

        private int checkColsSequences()
        {
            int score = 0;

            for (int i = 0; i < ColSize; i++)
            {
                for (int j = 0; j < RowSize - 3; j++)
                {
                    char[] seq = new char[4]
                                     {
                                         this.r_Board[j, i].Sign, this.r_Board[j + 1, i].Sign, this.r_Board[j + 2, i].Sign,
                                         this.r_Board[j + 3, i].Sign
                                     };
                    score += getSequenceScore(seq);
                }
            }

            return score;
        }

        private int checkUpToDownDiagonalSequences()
        {
            int score = 0;

            for (int i = 0; i < RowSize - 3; i++)
            {
                for (int j = 0; j < ColSize - 3; j++)
                {
                    char[] seq = new char[4]
                                     {
                                         this.r_Board[i, j].Sign, this.r_Board[i + 1, j + 1].Sign, this.r_Board[i + 2, j + 2].Sign,
                                         this.r_Board[i + 3, j + 3].Sign
                                     };
                    score += getSequenceScore(seq);
                }
            }

            return score;
        }

        private int checkDownToUpDiagonalSequences()
        {
            int score = 0;

            for (int i = ColSize - 1; i >= 3; i--)
            {
                for (int j = 0; j < RowSize - 3; j++)
                {
                    char[] seq = new char[4]
                                     {
                                         this.r_Board[j, i].Sign, this.r_Board[j + 1, i - 1].Sign, this.r_Board[j + 2, i - 2].Sign,
                                         this.r_Board[j + 3, i - 3].Sign
                                     };
                    score += getSequenceScore(seq);
                }
            }

            return score;
        }

        private int getSequenceScore(char[] i_SeqArray)
        {
            int player = 0;
            int computer = 0;
            int empty = 0;
            int resScore = 0;

            foreach (char value in i_SeqArray)
            {
                switch (value)
                {
                    case 'X':
                        player++;
                        break;
                    case 'O':
                        computer++;
                        break;
                    default:
                        empty++;
                        break;
                }
            }

            if (computer == 3 && empty == 1)
            {
                resScore = 100;
            }
            else if (player == 3 && empty == 1)
            {
                resScore = -200;
            }
            else if (computer == 2 && empty == 2)
            {
                resScore = 50;
            }
            else if (player == 2 && empty == 2)
            {
                resScore = -50;
            }

            return resScore;
        }

        public bool IsValidCol(int i_Col)
        {
            return i_Col >= 1 && i_Col <= this.ColSize && r_Board[0, i_Col - 1].Sign == ' ';
        }
    }
}
