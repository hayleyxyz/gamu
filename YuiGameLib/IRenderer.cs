using System;

using YuiGameLib.Graphics;

namespace YuiGameLib {
    public interface IRenderer {

        void Clear(RGBA colour);
        IImage LoadImage(string filePath);

    }
}
