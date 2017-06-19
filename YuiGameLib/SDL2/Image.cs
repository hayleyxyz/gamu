using System;
using SDL2;

using YuiGameLib.Graphics;

namespace YuiGameLib.SDL2 {
    public class Image : IImage {

        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public IntPtr SdlTexture;

        public Image(IntPtr sdlRenderer, string filePath) {
            this.SdlTexture = SDL_image.IMG_LoadTexture(sdlRenderer, filePath);

            uint format;
            int access, w, h;

            SDL.SDL_QueryTexture(this.SdlTexture, out format, out access, out w, out h);

            this.Width = w;
            this.Height = h;
        }

    }
}
