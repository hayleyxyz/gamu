using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuiGameLib.Graphics {
    public struct RGBA {

        public double r, g, b, a;

        public int Red {
            get { return (int)(this.r * 255); }
            set { this.r = value / 255; }
        }

        public int Green {
            get { return (int)(this.g * 255); }
            set { this.g = value / 255; }
        }

        public int Blue {
            get { return (int)(this.b * 255); }
            set { this.b = value / 255; }
        }

        public int Alpha {
            get { return (int)(this.a * 255); }
            set { this.a = value / 255; }
        }

        public RGBA(int r, int g, int b, int a) : this(r / 255f, g / 255f, b / 255f, a / 255f) { }

        public RGBA(int r, int g, int b) : this(r, g, b, 255) { }

        public RGBA(double r, double g, double b) : this(r, g, b, 1f) { }

        public RGBA(double r, double g, double b, double a) {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public override string ToString() {
            return String.Format("RGBA({0}, {1}, {2}, {3})", this.Red, this.Green, this.Blue, this.Alpha);
        }

    }
}
