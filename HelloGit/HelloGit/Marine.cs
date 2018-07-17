using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloGit
{
    class Marine
    {
        int ph=100; // 체력
        int steam; // 스팀팩 (체력--)

        public int MinusPh(int p)
        {
            ph -= 10;
            return ph;
        }
    }
}
