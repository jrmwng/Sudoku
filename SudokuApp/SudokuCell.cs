using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApp
{
    public class SudokuCell
    {
        private readonly WeakReference<Sudoku> m_sudoku;
        public readonly int m_nY0, m_nX0, m_nY1, m_nX1;

        public int IndexX => m_nX0 * 3 + m_nX1;
        public int IndexY => m_nY0 * 3 + m_nY1;

        public SudokuCell(Sudoku sudoku, int nY0, int nX0, int nY1, int nX1)
        {
            m_sudoku = new WeakReference<Sudoku>(sudoku);
            m_nY0 = nY0;
            m_nX0 = nX0;
            m_nY1 = nY1;
            m_nX1 = nX1;
        }
    }
}
