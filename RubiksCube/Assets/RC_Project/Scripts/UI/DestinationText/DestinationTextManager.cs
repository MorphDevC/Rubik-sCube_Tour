using System;
using System.Collections.Generic;
using UnityEngine;

public class DestinationTextManager:MonoBehaviour
{
    public readonly Dictionary<byte, string> DestinationText = new Dictionary<byte, string>()
    {
        {1,"Лаборатория автоматизированных систем в защищенном исполнении"},
        {2,"Лаборатория специальных полимерных композитов кафедры оптических и биотехнический систем и технологий"},
        {3, "Коридор администрации"},
        {4,  "Компьютерный класс 239А"},
        {5,  "Кафетерий"},
        {6,"Бассейн"},
        {7, "Фойе Института" },
        {8,"Электронный ТИР"},
        {9, "Большой Ко-Воркинг"},
        {10,"Большой спортивный зал"},
        {11,"Тренажёрный зал"},
        {12,"Лингафонный кабинет "},
        {13,"Коридор администрации"},
        {14,"Лаборатория \"Интеллектуальные сенсорные системы\""},
        {15, "Вxод в Институт"},
        {16,"Лаборатория прецизионной обработки материалов кафедры оптических и биотехнический систем и технологий"},
        {17,"Зал ученого совета — вид слева"},
        {18,"Зал настольного тенниса"},
        {19,"Лаборатория механических испытаний материалов кафедры физики и химиии материалов им. Б.А. Догадкина"},
        {20,""},
        {21,"Коридор администрации"}, 
        {22,"Компьютерный класс 256"},
        {23,"Лаборатория структурного анализа материалов кафедры физики и химиии материалов им. Б.А. Догадкина"},
        {24,"Проход в Зал"},
        {25, "Обеденный зал"},
        {26, "Этаж 2"},
        {27,"Лаборатория цифровых технологий кафедры цифровых и аддитивных технологий"},
        {28,"Зал гимнастики"},
        {29, "Компьютерный класс 251А"}, 
        {30, "Ко-Воркинг"}, 
        {31,"Учебная лаборатория электроники кафедры электроники"},
        {32,"Лаборатория оптико-электронных приборов и систем специального назначения"},
        {33,"Лаборатория  программно-аппаратных средств защиты информации"},
        {34,"Этаж 3" },
        {35,"Учебная лаборатория электроники кафедры электроники"},
        {36, "Студенческая столовая — вход"},
        {37,"Чил-Аут 1" }, 
        {38,"Учебная лаборатория электроники кафедры электроники"},
        {39, "Переговорный кабинет"},
        {40,"Электронный ТИР"},
        {41, "Этаж 4"},
        {42,"Специализированный компьютерный класс кафедры ценнообразования"},
        {43, "Зал ученого совета — вид справа"},
        {44,"Учебная лаборатория электроники кафедры электроники"},
        {45,"Многофункциональный зал"},
        {46,"Лингафонный кабинет "},
        {47, "Чил-Аут 2"},
        {48,"Зал Кросс-Фита"}
    };

    [SerializeField] private List<ManagerPlaneAction> _planeActionManagerRef;
    
    private IDestinationText _destinationObject;
    private void Awake()
    {
        _destinationObject = GetComponentInChildren<IDestinationText>();
        _destinationObject.HideDestination();
        // if(_planeActionManagerRef !=null)
        // {
        //     foreach (var mgr in _planeActionManagerRef)
        //     {
        //         mgr.RegisterFuncOnPlaneEnter(ShowDestinationObject);
        //         mgr.RegisterFuncOnPlaneExit(HideDestinationObject);
        //     }
        // }
    }

    private void Start()
    {
        if(_planeActionManagerRef !=null)
        {
            foreach (var mgr in _planeActionManagerRef)
            {
                mgr.RegisterFuncOnPlaneEnter(ShowDestinationObject);
                mgr.RegisterFuncOnPlaneExit(HideDestinationObject);
            }
        }
    }

    public void ShowDestinationObject(byte targetText)
    {
        _destinationObject?.ShowDestination(DestinationText[targetText]);
    }

    public void HideDestinationObject()
    {
        _destinationObject.HideDestination();
    }
    
    
    
}
