#include "pch.h"
#include "SudokuSolver.h"

using namespace SudokuUWP;
using namespace Platform;

#include "sudoku.h"

namespace SudokuUWP
{
	struct sudoku_solver_t : jrmwng::sudoku_t<jrmwng::sudoku_9x9_traits> {};
}

SudokuSolver::SudokuSolver()
	: m_pSudokuSolver(new sudoku_solver_t)
	, m_nDirtyGroupSet(0)
{
}

SudokuSolver::~SudokuSolver()
{
	if (m_pSudokuSolver)
	{
		delete m_pSudokuSolver;
	}
}

void SudokuUWP::SudokuSolver::SetCandidates(int nCol, int nRow, int nCandidateSet)
{
	m_nDirtyGroupSet |= m_pSudokuSolver->set_candidates(nCol, nRow, nCandidateSet);
}

int SudokuUWP::SudokuSolver::GetCandidates(int nCol, int nRow)
{
	return m_pSudokuSolver->get_candidates(nCol, nRow);
}

void SudokuUWP::SudokuSolver::Update()
{
	m_pSudokuSolver->update(std::exchange(m_nDirtyGroupSet, 0));
}
