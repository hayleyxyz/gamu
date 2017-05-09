using System;
using YuiGameLib.Platform;

namespace YuiGameLib.GameObjects {
    public class Test : GameObject, IUpdateable, IDrawable {

        public Test(Game game) : base(game) {
        }

        public override void Initialize() {
            base.Initialize();

            var image = SDL_CS.SDL_image.IMG_Load("Resources/player-1.png");
            
        }

        public void Draw(IRenderer renderer) {
            var rect = new Graphics.Rect(0, 0, 100, 100);
            renderer.drawRect(
                rect,
                new Graphics.Colour(255, 0, 0)
            );
        }

        public void Update() {
            Console.WriteLine("Update");
        }
    }
}
