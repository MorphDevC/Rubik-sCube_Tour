using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class ShowPlaneDestinition
{


    //private Text[] ShowText =
    //{
    //   new Text("0"),
    //   new Text("1"),
    //   new Text("2"),
    //   new Text("3"),
    //   new Text("4"),
    //   new Text("5"),
    //   new Text("6"),
    //   new Text("7"),

    //};

    //public void ShowDestinationPlane(byte DestinText)
    //{
    //    ShowText[DestinText];
    //}

    #region BackUp

    //public string ShowDestinationPlane(byte DestinText)
    //{
    //    switch (DestinText)
    //    {
    //        #region Chillouts
    //        case 9:
    //            UI_DestinitionText.SetText("Большой Ко-Воркинг");
    //            break;
    //        case 30:
    //            UI_DestinitionText.SetText("Ко-Воркинг");
    //            break;
    //        case 37:
    //            UI_DestinitionText.SetText("Чил-Аут 1");
    //            break;
    //        case 47:
    //            UI_DestinitionText.SetText("Чил-Аут 2");
    //            break;
    //        #endregion

    //        #region LoungeStairsAction
    //        case 15:
    //            UI_DestinitionText.SetText("Вxод в Институт");
    //            break;
    //        case 7:
    //            UI_DestinitionText.SetText("Фойе Института");
    //            break;
    //        case 26:
    //            UI_DestinitionText.SetText("Этаж 2");
    //            break;
    //        case 34:
    //            UI_DestinitionText.SetText("Этаж 3");
    //            break;
    //        case 41:
    //            UI_DestinitionText.SetText("Этаж 4");
    //            break;
    //        #endregion

    //        #region Hall_3
    //        case 3:
    //            UI_DestinitionText.SetText("Коридор администрации");
    //            break;
    //        case 13:
    //            UI_DestinitionText.SetText("Коридор администрации");
    //            break;
    //        case 21:
    //            UI_DestinitionText.SetText("Коридор администрации");
    //            break;
    //        #endregion

    //        #region ClassRooms
    //        case 4:
    //            UI_DestinitionText.SetText("Компьютерный класс 239А");
    //            break;
    //        case 22:
    //            UI_DestinitionText.SetText("Компьютерный класс 256");
    //            break;
    //        case 29:
    //            UI_DestinitionText.SetText("Компьютерный класс 251А");
    //            break;
    //        case 39:
    //            UI_DestinitionText.SetText("Переговорный кабинет");
    //            break;
    //        #endregion

    //        #region Refectory
    //        case 5:
    //            UI_DestinitionText.SetText("Кафетерий");
    //            break;
    //        case 25:
    //            UI_DestinitionText.SetText("Обеденный зал");
    //            break;
    //        case 36:
    //            UI_DestinitionText.SetText("Студенческая столовая — вход");
    //            break;
    //        #endregion

    //        #region SCR
    //        case 17:
    //            UI_DestinitionText.SetText("Зал ученого совета — вид слева");
    //            break;
    //        case 43:
    //            UI_DestinitionText.SetText("Зал ученого совета — вид справа");
    //            break;
    //        #endregion

    //        #region FTI
    //        case 2:
    //            UI_DestinitionText.SetText("Лаборатория специальных полимерных композитов кафедры оптических и биотехнический систем и технологий");
    //            break;
    //        case 16:
    //            UI_DestinitionText.SetText("Лаборатория прецизионной обработки материалов кафедры оптических и биотехнический систем и технологий");
    //            break;
    //        case 19:
    //            UI_DestinitionText.SetText("Лаборатория механических испытаний материалов кафедры физики и химиии материалов им. Б.А. Догадкина");
    //            break;
    //        case 23:
    //            UI_DestinitionText.SetText("Лаборатория структурного анализа материалов кафедры физики и химиии материалов им. Б.А. Догадкина");
    //            break;
    //        case 27:
    //            UI_DestinitionText.SetText("Лаборатория цифровых технологий кафедры цифровых и аддитивных технологий");
    //            break;
    //        case 31:
    //            UI_DestinitionText.SetText("Учебная лаборатория электроники кафедры электроники");
    //            break;
    //        case 35:
    //            UI_DestinitionText.SetText("Учебная лаборатория электроники кафедры электроники");
    //            break;
    //        case 38:
    //            UI_DestinitionText.SetText("Учебная лаборатория электроники кафедры электроники");
    //            break;
    //        case 44:
    //            UI_DestinitionText.SetText("Учебная лаборатория электроники кафедры электроники");
    //            break;
    //        #endregion

    //        #region IKBSP
    //        case 1:
    //            UI_DestinitionText.SetText("Лаборатория автоматизированных систем в защищенном исполнении");
    //            break;
    //        case 14:
    //            UI_DestinitionText.SetText("Лаборатория \"Интеллектуальные сенсорные системы\"");
    //            break;
    //        case 32:
    //            UI_DestinitionText.SetText("Лаборатория оптико-электронных приборов и систем специального назначения");
    //            break;
    //        case 33:
    //            UI_DestinitionText.SetText("Лаборатория  программно-аппаратных средств защиты информации");
    //            break;
    //        case 42:
    //            UI_DestinitionText.SetText("Специализированный компьютерный класс кафедры ценнообразования");
    //            break;
    //        #endregion

    //        #region IEP
    //        case 8:
    //            UI_DestinitionText.SetText("Электронный ТИР");
    //            break;
    //        case 12:
    //            UI_DestinitionText.SetText("Лингафонный кабинет ");
    //            break;
    //        case 40:
    //            UI_DestinitionText.SetText("Электронный ТИР");
    //            break;
    //        case 46:
    //            UI_DestinitionText.SetText("Лингафонный кабинет ");
    //            break;
    //        #endregion

    //        #region SC
    //        case 6:
    //            UI_DestinitionText.SetText("Бассейн");
    //            break;
    //        case 10:
    //            UI_DestinitionText.SetText("Большой спортивный зал");
    //            break;
    //        case 11:
    //            UI_DestinitionText.SetText("Тренажёрный зал");
    //            break;
    //        case 18:
    //            UI_DestinitionText.SetText("Зал настольного тенниса");
    //            break;
    //        case 24:
    //            UI_DestinitionText.SetText("Проход в Зал");
    //            break;
    //        case 28:
    //            UI_DestinitionText.SetText("Зал гимнастики");
    //            break;
    //        case 45:
    //            UI_DestinitionText.SetText("Многофункциональный зал");
    //            break;
    //        case 48:
    //            UI_DestinitionText.SetText("Зал Кросс-Фита");
    //            break;
    //        #endregion
    //        case 20:

    //            break;

    //    }
    //}
    #endregion

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

    //public static void ShowAcademicDisciplineDest(GameObject PlaneDestinition, TextMeshProUGUI UI_text, string text)
    //{
    //    PlaneDestinition.SetActive(true);
    //    UI_text.SetText(text);
    //}

    //private void OptimizeCanvasFunc(GameObject CanvasItem, TextMeshProUGUI UI_Text, string text)
    //{
    //    UI_Text.SetText(text);
    //}
    
}

//public partial class Text
//{
//    private ShowPlaneDestinition _getTextMeshPro_obj;
//    public static string UI_text;
//    public Text(string setText)
//    {
//        UI_text = setText;
//        _getTextMeshPro_obj.UI_DestinitionText.SetText(setText);
//    }
//}


