using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Windsong_Lyre
{
    class AdvancedPlaySong
    {
        public AdvancedOpenTargetFile advancedOpenTargetFile = new AdvancedOpenTargetFile();

        public void Play()
        {
            Thread.Sleep(5000);
            advancedOpenTargetFile.openTargetFile();
        }    
    }
}
