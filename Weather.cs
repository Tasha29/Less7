using System;

namespace Less7
{
    class Weather
    {
        /*
        •дата
        •температура минимальная
        •температура максимальная
        •облачность -битовое перечисление
        •осадки-битовое перечисление
        •влажность
        •сила ветра
        •направление ветра-битовое перечисление
        •фаза луны -битовое перечисление
        
        */
        
        DateTime date;
        sbyte TempMin;
        sbyte TempMax;
        Dictionary.Overcast overcast;
        Dictionary.Fallouts fallouts;
        byte Humidity;
        byte WindForce;
        Dictionary.Wind wind;
        Dictionary.Moon moon;

      
        public DateTime Date { get => date; set => date = value; }
        public sbyte TempMin1 { get => TempMin; set => TempMin = value; }
        public sbyte TempMax1 { get => TempMax; set => TempMax = value; }
        public byte humidity;
        public byte windForce;
        public Dictionary.Overcast Overcast { get => overcast; set => overcast = value; }
        public Dictionary.Fallouts Fallouts { get => fallouts; set => fallouts = value; }
        public Dictionary.Wind Wind { get => wind; set => wind = value; }
        public Dictionary.Moon Moon { get => moon; set => moon = value; }

        public Weather(DateTime date, sbyte tempMin1, sbyte tempMax1, byte humidity, byte windForce,
                       Dictionary.Overcast overcast, Dictionary.Fallouts fallouts,
                       Dictionary.Wind wind, Dictionary.Moon moon)
        {
            Date = date;
            TempMin1 = tempMin1;
            TempMax1 = tempMax1;
            Overcast = overcast;
            Fallouts = fallouts;
            Humidity = humidity;
            WindForce = windForce;
            Wind = wind;
            Moon = moon;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()}\nтемпература мин:{TempMin1}г/ц - макс:{TempMax1}г/ц\nОблачность:{Overcast},\nОсадки:{Fallouts},\nВлажность:{Humidity}%,\nСкорость ветра:{WindForce}м/с\nНаправление ветра:{Wind},\nФаза луны:{Moon}";
        }
    }
}
