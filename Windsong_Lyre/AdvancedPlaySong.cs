using System.Threading;

namespace Windsong_Lyre
{
    class AdvancedPlaySong
    {
        public AdvancedOpenTargetFile advancedOpenTargetFile = new AdvancedOpenTargetFile();

        public void Play()
        {
            Thread.Sleep(5000); //gives the user 5 seconds before the next song plays
            advancedOpenTargetFile.openTargetFile();
        }    
    }
}
