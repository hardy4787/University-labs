using System;

namespace BL.Objects.Objects.Weathers
{
    public class Weather
    {
        Random x = new Random();
        public Weather()
        {

            
            season = "Лето";
            temp = x.Next(17, 32);

            deposits = "none";
            timeOfDay = "День";
        }
        
        public void SetSeason(string season)
        {
            if (season == "Зима")
                this.season = season;
            else
        if (season == "Осень")
                this.season = season;
            else
            if (season == "Весна")
                this.season = season;
            else
                if (season == "Лето")
                this.season = season;
        }
        public void SetTemp(int temp)
        {
            this.temp = temp;
        }
        public void SetDeposits(string deposits)
        {
            this.deposits = deposits;
        }
        public void SetTimeOfDay(string timeOfDay)
        {
            this.timeOfDay = timeOfDay;
        }
        public void SetCloudiness(int cloudiness)
        {
            this.cloudiness = cloudiness;
        }
        
        public int GetTemp()
        {
            return temp;
        }
        public string GetSeason()
        {
            return season;
        }
        public string GetDeposits()
        {
            return deposits;
        }
        public string GetTimeOfDay()
        {
            return timeOfDay;
        }
        
        public int GetCloudiness()
        {
            return cloudiness;
        }
        
        private int temp;// температура
        private int cloudiness; // облачность 

        private string season; // время года
        private string deposits; // осадки
        private string timeOfDay; // день или ночь
    }
}
