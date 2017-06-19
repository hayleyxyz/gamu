using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuiGameLib {
    public struct Vector2 {

        /// <summary>
        /// Returns the vector (0,0).
        /// </summary>
        public static Vector2 Zero { get { return new Vector2(); } }

        public float x;

        public float y;

        public Vector2(float x = 0, float y = 0) {
            this.x = x;
            this.y = y;
        }
    }
}
