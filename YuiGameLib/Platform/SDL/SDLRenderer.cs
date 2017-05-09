using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuiGameLib.Graphics;
using SDL_CS;

namespace YuiGameLib.Platform.SDL {
    public class SDLRenderer : IRenderer {
        private SDLGameWindow gameWindow;

        public SDLRenderer(SDLGameWindow gameWindow) {
            this.gameWindow = gameWindow;
        }

        public void drawRect(Rect rect, Colour colour) {
            var r = new SDL2.SDL_Rect();
            r.x = rect.X;
            r.y = rect.Y;
            r.w = rect.Width;
            r.h = rect.Height;

            SDL2.SDL_SetRenderDrawColor(this.gameWindow.Renderer, colour.r, colour.g, colour.b, colour.a);
            SDL2.SDL_RenderFillRect(this.gameWindow.Renderer, ref r);
        }

        public void BeginRender() {

        }

        public void EndRender() {
            SDL2.SDL_RenderPresent(this.gameWindow.Renderer);
        }

    }
}
