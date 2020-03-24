using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeper.App.Game.Presenter;

namespace MineSweeper.App.Game.View
{
    internal partial class GameForm : Form
    {
        private GamePresenter _presenter { get; }


        public GameForm(GamePresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

    }
}
