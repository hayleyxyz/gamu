using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuiGameLib;

namespace gamu {
    class Program {
        static void Main(string[] args) {

            var c = new YuiGameLib.Graphics.RGBA(93, 55, 44);
            var hsl = c.ToHSL();
            var rgb = hsl.ToRGBA();

            rgb.AdjustLightness(0.25);

            Console.WriteLine(c);
            Console.WriteLine("HSL({0}, {1}, {2})", hsl.h, hsl.s, hsl.l);
            Console.WriteLine(rgb);
            Console.ReadKey();

            var platform = new Platform();
            var game = new Game();

            platform.Run(game);
        }
    }
}
