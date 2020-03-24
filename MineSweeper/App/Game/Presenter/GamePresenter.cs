using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeper.App.Game.View;

namespace MineSweeper.App.Game.Presenter
{
    internal class GamePresenter
    {
        private GameForm _form { get; }


        public GamePresenter()
        {
            _form = new GameForm(this);
        }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_form);
        }
    }
}
