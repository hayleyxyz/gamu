using System;
using SDL2;

namespace YuiGameLib.Graphics {
    public class Renderer {

        protected IntPtr SdlRenderer;

        public Renderer(IntPtr sdlRenderer) {
            this.SdlRenderer = sdlRenderer;
        }

        public void DrawPoint(Vector2 point) {
            SDL.SDL_SetRenderDrawColor(this.SdlRenderer, 255, 0, 0, 255);
            SDL.SDL_RenderClear(this.SdlRenderer);

            var rect = new SDL.SDL_Rect() {
                x = 50,
                y = 50,
                w = 50,
                h = 50
            };

            SDL.SDL_SetRenderDrawColor(this.SdlRenderer, 0, 0, 255, 255);
            SDL.SDL_RenderFillRect(this.SdlRenderer, ref rect);
            SDL.SDL_RenderPresent(this.SdlRenderer);
        }

    }
}
