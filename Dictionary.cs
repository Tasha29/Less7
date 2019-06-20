using System;

namespace Less7
{
    class Dictionary
    {
        public enum Fallouts //Осадки: Не определено (информации нет), Дождь, Снег, Дождь со снегом, Град, Снежная крупа, Роса, Иней, Изморозь, Гололед, Ледяные иглы
        {
            undefined,
            rain,
            shower,
            snow,
            rain_snow,
            dew,
            frost,
            hoarfrost,
            icecrusted,
            fog,
            iceneedles,
        }
        public enum Overcast//Облачность: Не определено (информации нет), Ясно, Малооблачно, Облачно, Грозовые тучи.
        {
            undefined,
            clear,
            сloudy,
            overcast,//Облачно
            Stormclouds,//Грозовые тучи
        }
        public enum Wind //Направление ветра: Не определено (информации нет), Север, Северо- восток, Восток, Юго-восток, Юг, Юго-запад, Запад, Северо-запад.
        {
            undefined,
            north,
            northeast,
            east,
            southeast,
            south,
            southwest,
            west,
            northwest
        }
        public enum Moon//Фаза луны: Не определено (информации нет), Новолуние, Растущая, Полнолуние, Убывающая.
        {
            undefined,
            newmoon,
            growing,
            fullmoon,
            decrease//Убывающая
        };
    }
}
