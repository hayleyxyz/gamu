using System;
using SDL_CS;

namespace YuiGameLib.Platform.SDL {
    public class SDLGameWindow {

        protected int posx, posy;
        protected int width, height;

        protected IntPtr windowHandle, rendererHandle;

        public IntPtr Window { get { return windowHandle; } }

        public IntPtr Renderer { get { return rendererHandle; } }

        public SDLGameWindow(Game game) {
            posx = SDL2.SDL_WINDOWPOS_UNDEFINED;
            posy = SDL2.SDL_WINDOWPOS_UNDEFINED;

            width = 800;
            height = 400;

            this.CreateWindow();
        }

        protected void CreateWindow() {
            var flags =
                SDL2.SDL_WindowFlags.SDL_WINDOW_OPENGL |
                SDL2.SDL_WindowFlags.SDL_WINDOW_HIDDEN |
                SDL2.SDL_WindowFlags.SDL_WINDOW_INPUT_FOCUS |
                SDL2.SDL_WindowFlags.SDL_WINDOW_MOUSE_FOCUS;

            this.windowHandle = SDL2.SDL_CreateWindow(
                "",
                posx,
                posy,
                width,
                height,
                flags
            );

            var renderFlags = SDL2.SDL_RendererFlags.SDL_RENDERER_ACCELERATED;
            this.rendererHandle = SDL2.SDL_CreateRenderer(this.windowHandle, -1, renderFlags);
        }

        public void Show() {
            SDL2.SDL_ShowWindow(windowHandle);
        }

    }
}
