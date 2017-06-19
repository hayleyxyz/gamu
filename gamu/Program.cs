using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuiGameLib;

namespace gamu {
    class Program {
        static void Main(string[] args) {
            IPlatform platform = new SDLPlatform();
            var game = new Game();

            platform.Run(game);
        }
    }
}
