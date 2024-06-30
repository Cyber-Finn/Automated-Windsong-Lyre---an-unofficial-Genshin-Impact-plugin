using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Windsong_Lyre
{
    class PlaySong
    {
        public void Play(string directory, string filename)
        {
            Thread.Sleep(5000);
            
            OpenTargetFile newOpen = new OpenTargetFile();
            newOpen.openTargetFile(directory, filename);
        }
    }
}
