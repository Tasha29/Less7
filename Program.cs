using System;

namespace Less7
{
    class Program
    {
       /* enum fallouts //Осадки: Не определено (информации нет), Дождь, Снег, Дождь со снегом, Град, Снежная крупа, Роса, Иней, Изморозь, Гололед, Ледяные иглы
        {
            undefined,
            rain,
            shower,
            snow,
            dew,
            frost,
            hoarfrost,
            icecrusted,
            fog,
            iceneedles,
        }*/
        static void Main(string[] args)
        {

            /* Array fallouts = Enum.GetValues (typeof(fallouts));
             foreach (fallouts name in fallouts)
             Console.WriteLine(name);*/

            Weather weather1 = new Weather(new DateTime(2019,6,20), 28, 35, 85,6,Dictionary.Overcast.сloudy, Dictionary.Fallouts.rain,Dictionary.Wind.northwest, Dictionary.Moon.undefined);
            Console.WriteLine(weather1);
        }
    }
}
