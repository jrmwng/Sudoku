#pragma once

namespace SudokuUWP
{
	struct sudoku_solver_t;

    public ref class SudokuSolver sealed
    {
		sudoku_solver_t* const m_pSudokuSolver;
		int m_nDirtyGroupSet;
    public:
        SudokuSolver();
		virtual ~SudokuSolver();

		void SetCandidates(int nCol, int nRow, int nCandidateSet);
		int GetCandidates(int nCol, int nRow);

		void Update();
    };
}
