using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuiGameLib;
using YuiGameLib.SDL2;

namespace gamu {
    class Program {
        static void Main(string[] args) {
            IPlatform platform = new Platform();
            var game = new Game();

            platform.Run(game);
        }
    }
}
