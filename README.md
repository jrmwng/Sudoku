# Sudoku
XAML app for solving and designing sudoku puzzles

The UI is as simple as 81 combo boxes. When you select a number in a combo box, some numbers will be removed from some of the 81 combo boxes using a so-called 'preemptive set' technique

The implementation uses some x86-specific instructions / instruction set
- bit scan forward
- bit scan reverse
- population count
- SSE (4.1)

It takes about 100&micro;s to solve a sudoku puzzle with my computer (Intel Core i5-6300U)
