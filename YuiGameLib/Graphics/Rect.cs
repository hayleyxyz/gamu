using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuiGameLib.Graphics {
    public class Rect {

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rect(int x, int y, int w, int h) {
            this.X = x;
            this.Y = y;
            this.Width = w;
            this.Height = h;
        }

    }
}
