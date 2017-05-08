using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuiGameLib.GameObjects {
    public abstract class GameObject {

        public Game Game { get; protected set; }

        public GameObject(Game game) {

        }

    }
}
