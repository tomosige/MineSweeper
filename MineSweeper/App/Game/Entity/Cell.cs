using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper.App.Game.Entity
{
    internal class Cell
    {
        public bool isMine { get; }
        public bool isOpened { get; private set; } = false;

        public void Open()
        {
            isOpened = true;
        }
    }
}
