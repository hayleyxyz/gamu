using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuiGameLib {
    public interface IPlatform {

        bool Quitting { get; }

        void Run(Game game);

    }
}
