namespace classy_electronics
{
    public class TurnTable{
        //Properties
        public double CurrentSpeed {get; set;}
        public bool IsPlaying { get; set; }

        //Methods
        public void Play () {
            IsPlaying = true;
        } 
        public void Stop () {
            IsPlaying = false;
        } 

    }
}