using System;
using System.Diagnostics;
using SDL_CS;

namespace YuiGameLib.Platform.SDL {
    public class SDLGamePlatform {

        public Game Game { get; protected set; }

        public SDLGameWindow GameWindow { get; protected set; }

        public SDLRenderer Renderer { get; protected set; }

        public bool IsExiting { get; protected set; }

        public SDLGamePlatform(Game game) {
            this.IsExiting = false;

            var ver = new SDL2.SDL_version();
            SDL2.SDL_GetVersion(out ver);

            var compoundVer = 100 * ver.major + 10 * ver.minor + ver.patch;

            if (compoundVer <= 204) {
                Debug.WriteLine("Please use SDL 2.0.5 or higher.");
            }

            // Needed so VS can debug the project on Windows
            if (compoundVer >= 205 && Debugger.IsAttached) {
                SDL2.SDL_SetHint("SDL_WINDOWS_DISABLE_THREAD_NAMING", "1");
            }

            SDL2.SDL_Init(
                SDL2.SDL_INIT_VIDEO |
                SDL2.SDL_INIT_JOYSTICK |
                SDL2.SDL_INIT_GAMECONTROLLER |
                SDL2.SDL_INIT_HAPTIC
            );

            this.Game = game;
            this.GameWindow = new SDLGameWindow(game);
            this.Renderer = new SDLRenderer(GameWindow);
        }

        public void RunLoop() {
            GameWindow.Show();

            while(true) {
                SDLRunLoop();
                Game.Tick(this.Renderer);

                if(IsExiting) {
                    break;
                }
            }
        }

        protected void SDLRunLoop() {
            SDL2.SDL_Event ev;

            while (SDL2.SDL_PollEvent(out ev) == 1) {
                if(ev.type == SDL2.SDL_EventType.SDL_QUIT) {
                    this.IsExiting = true;
                }
            }
        }

    }
}
