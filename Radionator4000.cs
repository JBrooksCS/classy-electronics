using System.Collections.Generic;

namespace classy_electronics
{
    public class Radionator4000 : Speakanator3000
    {
        
        public double CurrentFrequency{get;set;}

        List <double> FavoriteStations{get;set;}

        public void AddFavorite(double station){
            FavoriteStations.Add(CurrentFrequency);
        }
        public void RemoveFavorite(double station){
            FavoriteStations.Remove(station);
        }
    }
}