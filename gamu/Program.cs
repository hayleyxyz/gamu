using System;
using YuiGameLib;
using YuiGameLib.Input;
using YuiGameLib.Graphics;
using YuiGameLib.SDL2;

namespace gamu {

    class MyGame : Game {
        
        public override void RunOnce() {
            if (this.Mouse.IsButtonDownOnce(MouseButton.Left)) {
                Platform.Renderer.Clear(new RGBA(20, 0, 0));

                //renderer.DrawPoint(new Vector2(50, 50));
            }
        }

    }

    class Program {
        static void Main(string[] args) {
            IPlatform platform = new Platform();
            var game = new MyGame();

            platform.Run(game);
        }
    }
}
