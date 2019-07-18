using System.Collections.Generic;

namespace classy_electronics
{
    public class Discotron5000 : Radionator4000
    {
        public int TotalTracks{get;set;}
        public int CurrentTrack{get;set;}

        public void NextTrack(){
            CurrentTrack = CurrentTrack+1;
        }
        public void PreviousTrack(){
            if (CurrentTrack > 0)
                CurrentTrack = CurrentTrack-1;
        }
    }
}