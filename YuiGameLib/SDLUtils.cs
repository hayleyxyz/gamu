using System;
using SDL2;
using YuiGameLib.Input;

namespace YuiGameLib {
    internal class SDLUtils {

        public static Input.MouseButton? SdlButtonToMouseButton(uint button) {
            switch(button) {
                case SDL.SDL_BUTTON_LEFT:
                    return MouseButton.Left;

                case SDL.SDL_BUTTON_RIGHT:
                    return MouseButton.Right;

                case SDL.SDL_BUTTON_MIDDLE:
                    return MouseButton.Middle;

                default:
                    return null;
            }
        }

    }
}
