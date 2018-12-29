using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csgo_Crosshair_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            UserControl control = new UserControl();
            BackLogic playerLogic = new BackLogic();


            control.Dialog();
            playerLogic.Randomizer();
        }
    }
}
