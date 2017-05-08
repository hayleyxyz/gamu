using System;
using System.Collections.Generic;
using YuiGameLib.GameObjects;
using YuiGameLib.Platform;

namespace YuiGameLib {
    public class Game {

        public List<GameObject> Objects;

        public Game() {
            Objects = new List<GameObject>();
        }

        internal void Tick(IRenderer renderer) {
            foreach (var obj in Objects) {
                if (obj is IUpdateable) {
                    ((IUpdateable)obj).Update();
                }
            }

            renderer.BeginRender();

            foreach (var obj in Objects) {
                if (obj is IDrawable) {
                    ((IDrawable)obj).Draw(renderer);
                }
            }

            renderer.EndRender();
        }
    }
}
