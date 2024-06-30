using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Windsong_Lyre
{
    class WellermanShanty
    {
        public void Play(string directory, string filename)
        {            
            OpenTargetFile newOpen = new OpenTargetFile();
            newOpen.openTargetFile(directory,filename);
        }
    }
}
