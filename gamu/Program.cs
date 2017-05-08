using System;
using YuiGameLib;
using YuiGameLib.GameObjects;
using YuiGameLib.Platform.SDL;

namespace gamu {
    class Program {
        static void Main(string[] args) {
            var game = new Game();
            game.Objects.Add(new Test(game));

            var platform = new SDLGamePlatform(game);
            platform.RunLoop();
        }
    }
}
