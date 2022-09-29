public static class ShowPlaneDestinition
{
    public static string SetNewText(byte DestinText)
    {
        switch (DestinText)
        {
            #region Chillouts
            case 9:
                return "Большой Ко-Воркинг";
            case 30:
                return "Ко-Воркинг";
            case 37:
                return "Чил-Аут 1";
            case 47:
                return "Чил-Аут 2";
            #endregion

            #region LoungeStairsAction
            case 15:
                return "Вxод в Институт";
            case 7:
                return "Фойе Института";
            case 26:
                return "Этаж 2";
            case 34:
                return "Этаж 3";
            case 41:
                return "Этаж 4";
            #endregion

            #region Hall_3
            case 3:
                return "Коридор администрации";
            case 13:
                return "Коридор администрации";
            case 21:
                return "Коридор администрации";
            #endregion

            #region ClassRooms
            case 4:
                return "Компьютерный класс 239А";
            case 22:
                return "Компьютерный класс 256";
            case 29:
                return "Компьютерный класс 251А";
            case 39:
                return "Переговорный кабинет";
            #endregion

            #region Refectory
            case 5:
                return "Кафетерий";
            case 25:
                return "Обеденный зал";
            case 36:
                return "Студенческая столовая — вход";
            #endregion

            #region SCR
            case 17:
                return "Зал ученого совета — вид слева";
            case 43:
                return "Зал ученого совета — вид справа";
            #endregion

            #region FTI
            case 2:
                return "Лаборатория специальных полимерных композитов кафедры оптических и биотехнический систем и технологий";
            case 16:
                return "Лаборатория прецизионной обработки материалов кафедры оптических и биотехнический систем и технологий";
            case 19:
                return "Лаборатория механических испытаний материалов кафедры физики и химиии материалов им. Б.А. Догадкина";
            case 23:
                return "Лаборатория структурного анализа материалов кафедры физики и химиии материалов им. Б.А. Догадкина";
            case 27:
                return "Лаборатория цифровых технологий кафедры цифровых и аддитивных технологий";
            case 31:
                return "Учебная лаборатория электроники кафедры электроники";
            case 35:
                return "Учебная лаборатория электроники кафедры электроники";
            case 38:
                return "Учебная лаборатория электроники кафедры электроники";
            case 44:
                return "Учебная лаборатория электроники кафедры электроники";
            #endregion

            #region IKBSP
            case 1:
                return "Лаборатория автоматизированных систем в защищенном исполнении";
            case 14:
                return "Лаборатория \"Интеллектуальные сенсорные системы\"";
            case 32:
                return "Лаборатория оптико-электронных приборов и систем специального назначения";
            case 33:
                return "Лаборатория  программно-аппаратных средств защиты информации";
            case 42:
                return "Специализированный компьютерный класс кафедры ценнообразования";
            #endregion

            #region IEP
            case 8:
                return "Электронный ТИР";
            case 12:
                return "Лингафонный кабинет ";
            case 40:
                return "Электронный ТИР";
            case 46:
                return "Лингафонный кабинет ";
            #endregion

            #region SC
            case 6:
                return "Бассейн";
            case 10:
                return "Большой спортивный зал";
            case 11:
                return "Тренажёрный зал";
            case 18:
                return "Зал настольного тенниса";
            case 24:
                return "Проход в Зал";
            case 28:
                return "Зал гимнастики";
            case 45:
                return "Многофункциональный зал";
            case 48:
                return "Зал Кросс-Фита";
            #endregion
            case 20:

                break;

        }
        return "";
    }
}
