using System;
using System.Collections.Generic;
using gamu.GameObjects;

namespace gamu {
    public class Game {

        public List<GameObject> Objects;

        public Game() {
            Objects = new List<GameObject>();
        }

        internal void Tick() {
            foreach (var obj in Objects) {
                if (obj is IUpdateable) {
                    ((IUpdateable)obj).Update();
                }
            }

            foreach (var obj in Objects) {
                if (obj is IDrawable) {
                    ((IDrawable)obj).Draw();
                }
            }
        }
    }
}
