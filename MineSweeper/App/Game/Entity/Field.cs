using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper.App.Game.Entity
{
    internal class Field
    {
        private List<List<Cell>> _cells { get; }


        public Field(int x, int y)
        {
            _cells =
                Enumerable.Repeat
                (
                    Enumerable.Repeat
                    (new Cell(), y).ToList(),
                    x
                )
                .ToList();
        }

        public Cell GetAt(int x, int y)
        {
            return _cells[x][y];
        }

        public int CountAllMine()
        {
            return _cells
                .SelectMany(cell => cell)
                .Count(cell => cell.isMine);
        }

        public int CountHidedMine()
        {
            return _cells
                .SelectMany(cell => cell)
                .Where(cell => cell.isOpened == false)
                .Count(cell => cell.isMine);
        }
    }
}
