using System;
using Native;

namespace YuiGameLib.Platform.SDL {
    public class SDLGameWindow {

        protected int posx, posy;
        protected int width, height;

        protected IntPtr windowHandle, rendererHandle;
        
        public IntPtr Window { get { return windowHandle; } }

        public IntPtr Renderer { get { return rendererHandle; } }

        public SDLGameWindow(Game game) {
            posx = Native.SDL.SDL_WINDOWPOS_UNDEFINED;
            posy = Native.SDL.SDL_WINDOWPOS_UNDEFINED;
            
            width = 800;
            height = 400;

            this.CreateWindow();
        }

        protected void CreateWindow() {
            var flags =
                Native.SDL.SDL_WindowFlags.SDL_WINDOW_OPENGL |
                Native.SDL.SDL_WindowFlags.SDL_WINDOW_HIDDEN |
                Native.SDL.SDL_WindowFlags.SDL_WINDOW_INPUT_FOCUS |
                Native.SDL.SDL_WindowFlags.SDL_WINDOW_MOUSE_FOCUS;

            this.windowHandle = Native.SDL.SDL_CreateWindow(
                "",
                posx,
                posy,
                width,
                height,
                flags
            );

            var renderFlags = Native.SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED;
            this.rendererHandle = Native.SDL.SDL_CreateRenderer(this.windowHandle, -1, renderFlags);
        }

        public void Show() {
            Native.SDL.SDL_ShowWindow(windowHandle);
        }

    }
}
