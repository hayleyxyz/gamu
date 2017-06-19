using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuiGameLib.Graphics {
    public struct HSL {

        public double h, s, l;

        public RGBA ToRGBA() {
            double h = this.h,
                s = this.s,
                l = this.l;

            if (l < 0) l = 0;
            if (s < 0) s = 0;
            if (l > 1) l = 1;
            if (s > 1) s = 1;
            while (h < 0) h += 1;
            while (h > 1) h -= 1;

            double m2;
            if (l <= 0.5) m2 = l * (s + 1.0);
            else m2 = (l + s) - (l * s);
            double m1 = (l * 2.0) - m2;

            double r = h_to_rgb(m1, m2, h + 1.0 / 3.0);
            double g = h_to_rgb(m1, m2, h);
            double b = h_to_rgb(m1, m2, h - 1.0 / 3.0);

            return new RGBA(r, g, b, 1f);
        }

        private double h_to_rgb(double m1, double m2, double h) {
            while (h < 0) h += 1;
            while (h > 1) h -= 1;
            if (h * 6.0 < 1) return m1 + (m2 - m1) * h * 6;
            if (h * 2.0 < 1) return m2;
            if (h * 3.0 < 2) return m1 + (m2 - m1) * (2.0 / 3.0 - h) * 6;
            return m1;
        }

    }
}
