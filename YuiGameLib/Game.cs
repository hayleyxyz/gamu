using System;
using log4net;
using YuiGameLib.Graphics;
using YuiGameLib.Input;

namespace YuiGameLib {
    public class Game {

        protected ILog Logger = LogManager.GetLogger(typeof(Game));

        public Mouse Mouse { get; protected set; }

        public Game() {
            Mouse = new Mouse();
        }

        internal void RunOnce() {
            if(this.Mouse.IsButtonDownOnce(MouseButton.Left)) {
                Logger.Debug("Mouse.IsButtonDownOnce");
                //renderer.DrawPoint(new Vector2(50, 50));
            }
        }
    }
}
