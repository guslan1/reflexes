using System;
using System.Collections.Generic;
using System.Text;

namespace reflexes.Controller
{
    public interface LevelController
    {
        void Easy();

        void Medium();

        void Hard();

        bool Play();
    }
}
