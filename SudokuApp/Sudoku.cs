using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace SudokuApp
{
    public class Sudoku
    {
        private readonly ComboBox[,,,] m_aaaaComboBox;

        private readonly SudokuUWP.SudokuSolver m_solver = new SudokuUWP.SudokuSolver();
        private readonly SudokuCell[,,,] m_aaCell = new SudokuCell[3, 3, 3, 3];

        public SudokuUWP.SudokuSolver Solver => m_solver;

        public SudokuCell Cell0000 => m_aaCell[0, 0, 0, 0];
        public SudokuCell Cell0001 => m_aaCell[0, 0, 0, 1];
        public SudokuCell Cell0002 => m_aaCell[0, 0, 0, 2];
        public SudokuCell Cell0010 => m_aaCell[0, 0, 1, 0];
        public SudokuCell Cell0011 => m_aaCell[0, 0, 1, 1];
        public SudokuCell Cell0012 => m_aaCell[0, 0, 1, 2];
        public SudokuCell Cell0020 => m_aaCell[0, 0, 2, 0];
        public SudokuCell Cell0021 => m_aaCell[0, 0, 2, 1];
        public SudokuCell Cell0022 => m_aaCell[0, 0, 2, 2];
        public SudokuCell Cell0100 => m_aaCell[0, 1, 0, 0];
        public SudokuCell Cell0101 => m_aaCell[0, 1, 0, 1];
        public SudokuCell Cell0102 => m_aaCell[0, 1, 0, 2];
        public SudokuCell Cell0110 => m_aaCell[0, 1, 1, 0];
        public SudokuCell Cell0111 => m_aaCell[0, 1, 1, 1];
        public SudokuCell Cell0112 => m_aaCell[0, 1, 1, 2];
        public SudokuCell Cell0120 => m_aaCell[0, 1, 2, 0];
        public SudokuCell Cell0121 => m_aaCell[0, 1, 2, 1];
        public SudokuCell Cell0122 => m_aaCell[0, 1, 2, 2];
        public SudokuCell Cell0200 => m_aaCell[0, 2, 0, 0];
        public SudokuCell Cell0201 => m_aaCell[0, 2, 0, 1];
        public SudokuCell Cell0202 => m_aaCell[0, 2, 0, 2];
        public SudokuCell Cell0210 => m_aaCell[0, 2, 1, 0];
        public SudokuCell Cell0211 => m_aaCell[0, 2, 1, 1];
        public SudokuCell Cell0212 => m_aaCell[0, 2, 1, 2];
        public SudokuCell Cell0220 => m_aaCell[0, 2, 2, 0];
        public SudokuCell Cell0221 => m_aaCell[0, 2, 2, 1];
        public SudokuCell Cell0222 => m_aaCell[0, 2, 2, 2];
        public SudokuCell Cell1000 => m_aaCell[1, 0, 0, 0];
        public SudokuCell Cell1001 => m_aaCell[1, 0, 0, 1];
        public SudokuCell Cell1002 => m_aaCell[1, 0, 0, 2];
        public SudokuCell Cell1010 => m_aaCell[1, 0, 1, 0];
        public SudokuCell Cell1011 => m_aaCell[1, 0, 1, 1];
        public SudokuCell Cell1012 => m_aaCell[1, 0, 1, 2];
        public SudokuCell Cell1020 => m_aaCell[1, 0, 2, 0];
        public SudokuCell Cell1021 => m_aaCell[1, 0, 2, 1];
        public SudokuCell Cell1022 => m_aaCell[1, 0, 2, 2];
        public SudokuCell Cell1100 => m_aaCell[1, 1, 0, 0];
        public SudokuCell Cell1101 => m_aaCell[1, 1, 0, 1];
        public SudokuCell Cell1102 => m_aaCell[1, 1, 0, 2];
        public SudokuCell Cell1110 => m_aaCell[1, 1, 1, 0];
        public SudokuCell Cell1111 => m_aaCell[1, 1, 1, 1];
        public SudokuCell Cell1112 => m_aaCell[1, 1, 1, 2];
        public SudokuCell Cell1120 => m_aaCell[1, 1, 2, 0];
        public SudokuCell Cell1121 => m_aaCell[1, 1, 2, 1];
        public SudokuCell Cell1122 => m_aaCell[1, 1, 2, 2];
        public SudokuCell Cell1200 => m_aaCell[1, 2, 0, 0];
        public SudokuCell Cell1201 => m_aaCell[1, 2, 0, 1];
        public SudokuCell Cell1202 => m_aaCell[1, 2, 0, 2];
        public SudokuCell Cell1210 => m_aaCell[1, 2, 1, 0];
        public SudokuCell Cell1211 => m_aaCell[1, 2, 1, 1];
        public SudokuCell Cell1212 => m_aaCell[1, 2, 1, 2];
        public SudokuCell Cell1220 => m_aaCell[1, 2, 2, 0];
        public SudokuCell Cell1221 => m_aaCell[1, 2, 2, 1];
        public SudokuCell Cell1222 => m_aaCell[1, 2, 2, 2];
        public SudokuCell Cell2000 => m_aaCell[2, 0, 0, 0];
        public SudokuCell Cell2001 => m_aaCell[2, 0, 0, 1];
        public SudokuCell Cell2002 => m_aaCell[2, 0, 0, 2];
        public SudokuCell Cell2010 => m_aaCell[2, 0, 1, 0];
        public SudokuCell Cell2011 => m_aaCell[2, 0, 1, 1];
        public SudokuCell Cell2012 => m_aaCell[2, 0, 1, 2];
        public SudokuCell Cell2020 => m_aaCell[2, 0, 2, 0];
        public SudokuCell Cell2021 => m_aaCell[2, 0, 2, 1];
        public SudokuCell Cell2022 => m_aaCell[2, 0, 2, 2];
        public SudokuCell Cell2100 => m_aaCell[2, 1, 0, 0];
        public SudokuCell Cell2101 => m_aaCell[2, 1, 0, 1];
        public SudokuCell Cell2102 => m_aaCell[2, 1, 0, 2];
        public SudokuCell Cell2110 => m_aaCell[2, 1, 1, 0];
        public SudokuCell Cell2111 => m_aaCell[2, 1, 1, 1];
        public SudokuCell Cell2112 => m_aaCell[2, 1, 1, 2];
        public SudokuCell Cell2120 => m_aaCell[2, 1, 2, 0];
        public SudokuCell Cell2121 => m_aaCell[2, 1, 2, 1];
        public SudokuCell Cell2122 => m_aaCell[2, 1, 2, 2];
        public SudokuCell Cell2200 => m_aaCell[2, 2, 0, 0];
        public SudokuCell Cell2201 => m_aaCell[2, 2, 0, 1];
        public SudokuCell Cell2202 => m_aaCell[2, 2, 0, 2];
        public SudokuCell Cell2210 => m_aaCell[2, 2, 1, 0];
        public SudokuCell Cell2211 => m_aaCell[2, 2, 1, 1];
        public SudokuCell Cell2212 => m_aaCell[2, 2, 1, 2];
        public SudokuCell Cell2220 => m_aaCell[2, 2, 2, 0];
        public SudokuCell Cell2221 => m_aaCell[2, 2, 2, 1];
        public SudokuCell Cell2222 => m_aaCell[2, 2, 2, 2];

        public Sudoku(ComboBox[,,,] aaaaComboBox)
        {
            m_aaaaComboBox = aaaaComboBox;

            for (int nY0 = 0; nY0 < 3; nY0++)
            {
                for (int nX0 = 0; nX0 < 3; nX0++)
                {
                    for (int nY1 = 0; nY1 < 3; nY1++)
                    {
                        for (int nX1 = 0; nX1 < 3; nX1++)
                        {
                            var cell = new SudokuCell(this, nY0, nX0, nY1, nX1);

                            m_aaCell[nY0, nX0, nY1, nX1] = cell;
                            m_aaaaComboBox[nY0, nX0, nY1, nX1].Tag = cell;

                            foreach (int nNum in Enumerable.Range(1, 9))
                            {
                                m_aaaaComboBox[nY0, nX0, nY1, nX1].Items.Add(nNum);
                            }
                        }
                    }
                }
            }
        }

        public void SetNumber(SudokuCell cell, int nNum)
        {
            m_solver.SetCandidates(cell.IndexX, cell.IndexY, (1 << (nNum - 1)));
        }
        public void Update()
        {
            m_solver.Update();

            for (int nY0 = 0; nY0 < 3; nY0++)
            {
                for (int nX0 = 0; nX0 < 3; nX0++)
                {
                    for (int nY1 = 0; nY1 < 3; nY1++)
                    {
                        for (int nX1 = 0; nX1 < 3; nX1++)
                        {
                            var cell = m_aaCell[nY0, nX0, nY1, nX1];
                            var box = m_aaaaComboBox[nY0, nX0, nY1, nX1];

                            int nCandidateSet = m_solver.GetCandidates(cell.IndexX, cell.IndexY);

                            foreach (var nRemove in Enumerable.Range(1, 9).Where(n => (nCandidateSet & (1 << (n - 1))) == 0))
                            {
                                box.Items.Remove(nRemove);
                            }

                            switch (box.Items.Count)
                            {
                                case 1:
                                    if (box.SelectedIndex == -1)
                                    {
                                        box.Background = App.Current.Resources[@"SolidGreenBrush"] as Brush;
                                    }
                                    break;
                                case 0:
                                    box.Background = App.Current.Resources[@"SolidRedBrush"] as Brush;
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
