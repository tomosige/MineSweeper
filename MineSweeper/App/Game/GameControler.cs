using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeper.App.Game.Presenter;

namespace MineSweeper.App.Game
{
    public class GameControler
    {
        public GameControler()
        {
            
        }

        public void Run()
        {
            new GamePresenter().Run();
        }
    }
}
