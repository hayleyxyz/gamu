using System;
using System.IO;
using SDL2;
using log4net;

namespace YuiGameLib {
    public class Platform {

        protected ILog Logger = LogManager.GetLogger(typeof(Platform));

        public bool Quitting { get; protected set; }

        protected IntPtr SdlWindow = IntPtr.Zero;

        protected IntPtr SdlRenderer = IntPtr.Zero;

        public Platform() {
            // Setup DLL path so the correct SDL libs can be loaded
            this.SetDllPath();

            log4net.Config.XmlConfigurator.Configure();

            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

            this.SdlWindow = SDL.SDL_CreateWindow("sdl", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 640, 640, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
            this.SdlRenderer = SDL.SDL_CreateRenderer(this.SdlWindow, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
        }

        public void Run(Game game) {
            var renderer = new Graphics.Renderer(this.SdlRenderer);

            while(!Quitting) {
                var ev = new SDL.SDL_Event();
                Input.MouseButton? button = null;

                while (SDL.SDL_PollEvent(out ev) > 0) {
                    switch(ev.type) {
                        case SDL.SDL_EventType.SDL_QUIT:
                            Quitting = true;
                            break;

                        case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                            Logger.Debug("SDL_MOUSEBUTTONDOWN");

                            button = SDLUtils.SdlButtonToMouseButton(ev.button.button);
                            if (button != null) {
                                game.Mouse.SetButtonDown((Input.MouseButton)button);
                            }

                            break;

                        case SDL.SDL_EventType.SDL_MOUSEBUTTONUP:
                            Logger.Debug("SDL_MOUSEBUTTONUP");

                            button = SDLUtils.SdlButtonToMouseButton(ev.button.button);
                            if (button != null) {
                                game.Mouse.SetButtonDown((Input.MouseButton)button);
                            }

                            break;
                    }
                }


                game.RunOnce(renderer);
            }
            
            SDL.SDL_Quit();
        }

        protected void SetDllPath() {
            if (this.Is64BitProcess()) {
                NativeMethods.SetDllDirectory(Path.Combine(Environment.CurrentDirectory, "x64"));
            }
            else {
                NativeMethods.SetDllDirectory(Path.Combine(Environment.CurrentDirectory, "x86"));
            }
        }

        public bool Is64BitProcess() {
            return IntPtr.Size == 8;
        }
    }
}
