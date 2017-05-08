using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuiGameLib.Graphics;

namespace YuiGameLib.Platform {
    public interface IRenderer {
        void BeginRender();
        void EndRender();
        void drawRect(Rect rect, Colour colour);
    }
}
