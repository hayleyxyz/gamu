using System;
using SDL2;

using YuiGameLib.Graphics;

namespace YuiGameLib.SDL2 {
    public class Renderer : IRenderer {

        protected IntPtr SdlPointer;

        public Renderer(IntPtr sdlPointer) {
            this.SdlPointer = sdlPointer;
        }

        protected void SetDrawColour(RGBA colour) {
            SDL.SDL_SetRenderDrawColor(this.SdlPointer, (byte)colour.Red, (byte)colour.Green, (byte)colour.Blue, (byte)colour.Alpha);
        }

        public void Clear(RGBA colour) {
            this.SetDrawColour(colour);
            SDL.SDL_RenderClear(this.SdlPointer);
        }

        public IImage LoadImage(string filePath) {
            return null;
        }



#if false
        public void DrawPoint(Vector2 point) {
            SDL.SDL_SetRenderDrawColor(this.SdlRenderer, 255, 0, 0, 255);
            

            var rect = new SDL.SDL_Rect() {
                x = 50,
                y = 50,
                w = 50,
                h = 50
            };

            SDL.SDL_SetRenderDrawColor(this.SdlRenderer, 0, 0, 255, 255);
            SDL.SDL_RenderFillRect(this.SdlRenderer, ref rect);
            
        }
#endif

    }
}
