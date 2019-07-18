namespace classy_electronics
{
    public class Speakanator3000 : TurnTable
    {
        
        public int Volume{get; set;}

        public void VolumeUp(){
            Volume = Volume++;
        }
        public void VolumeDown(){
            Volume = Volume--;
        }
    }
}