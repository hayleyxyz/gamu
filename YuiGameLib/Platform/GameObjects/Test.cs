using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamu.GameObjects {
    public class Test : GameObject, IUpdateable, IDrawable {

        public Test(Game game) : base(game) {
        }

        public void Draw() {
            Console.WriteLine("Draw");
        }

        public void Update() {
            Console.WriteLine("Update");
        }
    }
}
