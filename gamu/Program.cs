using System;
using System.Runtime.InteropServices;
using YuiGameLib;
using YuiGameLib.GameObjects;
using YuiGameLib.Platform.SDL;

namespace gamu {
    class Program {

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDllDirectory(string lpPathName);

        static void Main(string[] args) {
            SetDllDirectory("x64");

            var game = new Game();
            game.Objects.Add(new Test(game));

            var platform = new SDLGamePlatform(game);
            platform.RunLoop();
        }
    }
}
