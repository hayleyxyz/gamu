using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuiGameLib.Graphics {
    public class Colour {

        public byte r, g, b, a;

        public Colour(byte r, byte g, byte b, byte a) {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public Colour(byte r, byte g, byte b) : this(r, g, b, 255) {

        }
    }
}
