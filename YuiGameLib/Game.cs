using System;
using log4net;

using YuiGameLib.Graphics;
using YuiGameLib.Input;

namespace YuiGameLib {
    public abstract class Game {

        protected ILog Logger = LogManager.GetLogger(typeof(Game));

        public IPlatform Platform { get; set; }

        public Mouse Mouse { get; protected set; }

        public Game() {
            Mouse = new Mouse();
        }

        public abstract void LoadContent();

        public virtual void RunOnce() {
            
        }
    }
}
