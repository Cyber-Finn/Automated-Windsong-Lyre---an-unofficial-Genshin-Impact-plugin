using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Windsong_Lyre
{
    class PortOrmos
    {
        public void Play(string directory, string filename)
        {
            Thread.Sleep(5000);
            // use this one: https://www.youtube.com/watch?v=bRMLLQsQ4pE

            OpenTargetFile newOpen = new OpenTargetFile();
            newOpen.openTargetFile(directory, filename);

        }
    }
}
