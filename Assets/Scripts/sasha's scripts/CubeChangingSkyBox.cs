using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

/// <summary>
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using UnityEngine.SceneManagement;
/// </summary>

public class CubeChangingSkyBox : MonoBehaviour
{
    public ShowPlaneDestinition ShowPlaneDestinition;

    [Header("GameObjects")]
    public GameObject NavUp;
    public GameObject NavDown;
    public GameObject PannelNavigation;
    public GameObject[] teleportRefectory = new GameObject[2];
    // 0 - right
    // 1 - left
    public GameObject MainSceneObjects;
    public GameObject PanoramSceneObjects;
    public GameObject UI_MainSceneCanvas;
    public GameObject UI_PanoramSceneCanvas;
    public GameObject UI_ImageBackground;



    [Header ("SkyBoxes_SportComplex")]
    public Material[] SC_SkyBoxes= new Material[8];
    ////////////////////////////////////////////////////////////////////////////////////////////////////////


    [Header("SkyBoxes_RTU_MIREA")]
    //public GameObject ChillOuts; // панель навигвации
    //public GameObject ChillNav; // arrow nav
    public Material[] ChilloutsMats = new Material[4];
    // 0 - Chillout1
    // 1 - ChillOut2
    // 2 - ChillOut3
    // 3 - ChillOut4
    
    //public GameObject StairsAndHallArrows; // arrows nav. SetActive in NavStairsSph.cs
    //public GameObject NavUp;
    //public GameObject NavDown;
    public Material[] LoungeStairsSkyBox = new Material[5];
    
    public Material[] Classromms = new Material[4];
    // 4(0) - 239
    // 22(1) - 256
    // 29(2) - 251
    // 39(3) - 310 - rework
   
    
    public Material[] Refectory = new Material[3];
    // 5  (0) - RefectoryLeft
    // 25 (1) - RefectoryRight
    // 36 (2) - RefectoryMiddle

    public Material[] Hall_3= new Material[3];
    // 13 (0) - Hall3_1
    // 20, 34, -87.5f - up
    // 21 (1) - Hall3_2
    // 23, 36, -34 - up
    // -29, 36, -93 - down
    // 3  (2) - Hall3_3
    // 22.5f, 36, -37 - down
    
    public Material[] SocietyRoom = new Material[2];
    // 17 (0) - SCR_1
    // 43 (1) - SCR_2
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////


    [Header("SkyBoxes_IKBSP")]
    public Material[] IKBSP_SkyboxesMats = new Material[5];
    
    [Header("SkyBoxes_FTI")]
    public Material[] FTI_SkyBoxesMats = new Material[9];

    [Header("SkyBoxes_IEP")]
    public Material[] IEP_SkyBoxes = new Material[2];


    public Material Default;
    
    private static GameObject MainCube;
    private static Vector3 _vectorCameraAngles;
    private static bool _inChiillPannel;
    private bool _backToCube = false;

    #region WTF
    //private Navigation Navigation; // ПОЧЕМУ ЭТО РАБОТАЕТ
    //private Navigation _navigation = new Navigation(); // А ЭТО НЕ РАБОТАЕТ
    #endregion
    private static Vector3 VectorCameraAngles { get => _vectorCameraAngles; set => _vectorCameraAngles = value; }
    public static bool InChiillPannel { get => _inChiillPannel; set => _inChiillPannel = value; } //for using 1 pannel for Classrooms and ChillOuts



    private void Start()
    {
        MainCube = GameObject.FindWithTag("cube");
    }



    public void ChangeSkyBox(byte WhichPlane)
    {
        //_backToCube = true;
        //if (PlanesActions.DoNotUseSomeStringsInCubeChangeSky)
        //{   
        //    //CubeCanvas.SetActive(false);
        //    //Envirement.SetActive(false);
        //    MainCube.SetActive(false);

        //   // buttonToBack.SetActive(true);
        if (!PlanesActions.DoNotUseSomeStringsInCubeChangeSky)
        {
            UI_MainSceneCanvas.SetActive(false);
            UI_PanoramSceneCanvas.SetActive(true);
            FieldOfView.zoom = true; // static var in FieldOfView script
            MainSceneObjects.SetActive(false);
            PanoramSceneObjects.SetActive(true);
            Camera.main.transform.localEulerAngles = new Vector3(0, 0, 0);
            Camera.main.GetComponent<CamMouseLock>().enabled = true;
            PlanesActions.DoNotUseSomeStringsInCubeChangeSky = true;
        }
        //}
        switch (WhichPlane)
        {
            #region ChilloutsAction
            case 9:
                #region BackUpStrings
                //ChillOuts.SetActive(true);
                //ChillOuts.GetComponent<Animator>().SetTrigger("ChillAnim1");
                //PannelActionFunc(ChillOuts, ChillOuts.GetComponent<Animator>(), "ChillAnim1");
                #endregion
                RenderSettings.skybox = ChilloutsMats[0];
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-150, 20, -60), new Vector3(-90, 0, -80), true);
                NavigationPannel.SetNavUpDownSpheresFalse(NavUp,NavDown);
                // 1st Vector = position
                // 2nd vector = localEulerAngles
                
                break;
            case 30:
                RenderSettings.skybox = ChilloutsMats[1];
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-2, 25, 69), new Vector3(-90, 85, -90), true);
                NavigationPannel.SetNavUpDownSpheresFalse(NavUp, NavDown);
                break;
            case 37:
                RenderSettings.skybox = ChilloutsMats[2];
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(102, 20, 53), new Vector3(-90, 0, 33), true);
                NavigationSphere.SetNavUpDownSpheres(NavDown, NavUp, new Vector3(6, 34, -41), 8);
                //NavStairsSph.HallOrStair = 8; // Added when made reDesign on Navigation 
                
                break;
            case 47:
                RenderSettings.skybox = ChilloutsMats[3];
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-105, 35, -145), new Vector3(-90, 0, -127), true);
                NavigationPannel.SetNavUpDownSpheresFalse(NavUp, NavDown);
                
                break;
            #endregion

            #region LoungeStairsAction
            case 15:
                RenderSettings.skybox = LoungeStairsSkyBox[0];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-22, 39, -36), 0);
                break;
            case 7:
                RenderSettings.skybox = LoungeStairsSkyBox[1];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-14, 43, -88), new Vector3(23, 35, -69), 1);
                // go to LoungeStairsClass and set LoungeWhichFloor new val cuz in
                // switch case we watching at which floor but if we go on other floor
                // from main cube we have to change this var
                break;
            case 26:
                RenderSettings.skybox = LoungeStairsSkyBox[2];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-29, 43, -76), new Vector3(-14, 27, -81), 2);

                break;
            case 34:
                RenderSettings.skybox = LoungeStairsSkyBox[3];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-27, 44, -59.5f), new Vector3(-7, 29, -41), 3);

                break;
            case 41:
                PannelNavigation.SetActive(false);
                RenderSettings.skybox = LoungeStairsSkyBox[4];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(21, 34, -63), new Vector3(-22, 30, -51.8f), 4);

                break;
            #endregion

            #region Hall3
            case 3:
                RenderSettings.skybox = Hall_3[2];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(22.5f, 36, -37), 7);
                //NavStairsSph.HallOrStair = 7; // to see decr look in LoungeStairs.cs
                break;
            case 13:
                RenderSettings.skybox = Hall_3[0];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(20, 34, -87.5f), 5);
                break;
            case 21:
                RenderSettings.skybox = Hall_3[1];
                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(23, 36, -34), new Vector3(-29, 36, -93), 6);                    
                break;
            #endregion

            #region Classroom
            case 4:
                RenderSettings.skybox = Classromms[0];
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(6,33,-235), new Vector3(-90, 0, -180), false);
                //InChiillPannel = false;
                break;
            case 22:
                RenderSettings.skybox = Classromms[1];
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(37,-3,88), new Vector3(-90, 0, 16), false);
                break;
            case 29:
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(35, 29, -280), new Vector3(-90, 0, -180), false);
                RenderSettings.skybox = Classromms[2];
                break;
            case 39:
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-140,22,-22), new Vector3(-90, 0, -70), false);
                RenderSettings.skybox = Classromms[3];
                break;
            #endregion

            #region Refectory
            case 5:
                NavigationRefectory.SetNavRefectory(teleportRefectory[1], teleportRefectory[0], new Vector3(260, 9, -147), 1);
                RenderSettings.skybox = Refectory[0];
                break;
            case 25:
                NavigationRefectory.SetNavRefectory(teleportRefectory[0], teleportRefectory[1], new Vector3(33, 4, 10), 1);
                RenderSettings.skybox = Refectory[1];
                break;
            case 36: 
                NavigationRefectory.SetNavRefectory(teleportRefectory[0], teleportRefectory[1], new Vector3(240, -13, 20), new Vector3(39, 2, -11), 2);
                RenderSettings.skybox = Refectory[2];
                break;
            #endregion

            #region SCR_Room
            case 17:
                teleportRefectory[0].SetActive(true);
                teleportRefectory[0].transform.localPosition = new Vector3(270, 10, -50);
                TeleportAction.RefPos = 3; // 1 - left or right doesntmatter
                RenderSettings.skybox = SocietyRoom[0];
                break;
            case 43:
                teleportRefectory[0].SetActive(true);
                teleportRefectory[0].transform.localPosition = new Vector3(7, 0, -84);
                TeleportAction.RefPos = 4; // 1 - left or right doesntmatter
                RenderSettings.skybox = SocietyRoom[1];
                // write a method
                break;
            #endregion

            #region FTI_SkyBoxes
            case 2:
                RenderSettings.skybox = FTI_SkyBoxesMats[0];
                break;
            case 16:
                RenderSettings.skybox = FTI_SkyBoxesMats[1];
                break;
            case 19:
                RenderSettings.skybox = FTI_SkyBoxesMats[2];
                break;
            case 23:
                RenderSettings.skybox = FTI_SkyBoxesMats[3];
                break;
            case 27:
                RenderSettings.skybox = FTI_SkyBoxesMats[4];
                break;
            case 31:
                RenderSettings.skybox = FTI_SkyBoxesMats[5];
                break;
            case 35:
                RenderSettings.skybox = FTI_SkyBoxesMats[6];
                break;
            case 38:
                RenderSettings.skybox = FTI_SkyBoxesMats[7];
                break;
            case 44:
                RenderSettings.skybox = FTI_SkyBoxesMats[8];
                break;
            #endregion

            #region IKBSP
            case 1:
                RenderSettings.skybox = IKBSP_SkyboxesMats[0];
                break;
            case 14:
                RenderSettings.skybox = IKBSP_SkyboxesMats[1];
                break;
            case 32:
                RenderSettings.skybox = IKBSP_SkyboxesMats[2];
                break;
            case 33:
                RenderSettings.skybox = IKBSP_SkyboxesMats[3];
                break;
            case 42:
                RenderSettings.skybox = IKBSP_SkyboxesMats[4];
                break;

            #endregion
            
            #region IEP
            case 8:
                RenderSettings.skybox = IEP_SkyBoxes[0];
                break;
            case 12:
                RenderSettings.skybox = IEP_SkyBoxes[1];
                break;
            case 40:
                RenderSettings.skybox = IEP_SkyBoxes[0];
                break;
            case 46:
                RenderSettings.skybox = IEP_SkyBoxes[1];
                break;

            #endregion

            #region SC
            case 6:
                RenderSettings.skybox = SC_SkyBoxes[0];
                break;
            case 10:
                RenderSettings.skybox = SC_SkyBoxes[1];
                break;
            case 11:
                RenderSettings.skybox = SC_SkyBoxes[2];
                break;
            case 18:
                RenderSettings.skybox = SC_SkyBoxes[3];
                break;
            case 24:
                RenderSettings.skybox = SC_SkyBoxes[4];
                break;
            case 28:
                RenderSettings.skybox = SC_SkyBoxes[5];
                break;
            case 45:
                RenderSettings.skybox = SC_SkyBoxes[6];
                break;
            case 48:
                RenderSettings.skybox = SC_SkyBoxes[7];
                break;
            #endregion
            
            case 20:
                RenderSettings.skybox = Default;
                break;
            
        }
    }

    private void PannelActionFunc(GameObject PannelGameObject, Animator PannelAnimator, string numberAnim)
    {
        PannelGameObject.SetActive(true);
        PannelAnimator.SetTrigger(numberAnim);
    }// SetPannelGameObj true and SetTrigger Anim

    public void ShowDestinationPlane(byte DestinText)
    {
        UI_ImageBackground.SetActive(true);
        ShowPlaneDestinition.ShowDestinationPlane(DestinText);
        //    switch (DestinText)
        //    {
        //        #region Chillouts
        //        case 9:
        //            //OptimizeCanvasFunc(RTU_CanvasItems, 1);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Большой Ко-Воркинг");
        //            #region BackUpStringsToShowCanvasItems
        //            //RTU_CanvasItems[0].SetActive(true);
        //            //RTU_CanvasItems[1].SetActive(true);
        //            //RTU_CanvasItems[2].SetActive(false);
        //            //RTU_CanvasItems[3].SetActive(false);
        //            //RTU_CanvasItems[4].SetActive(false);
        //            #endregion
        //            break;
        //        case 30:
        //            //OptimizeCanvasFunc(RTU_CanvasItems, 2);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Ко-Воркинг");
        //            break;
        //        case 37:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Чил-Аут 1");
        //            break;
        //        case 47:
        //            OptimizeCanvasFunc(RTU_Canvas,RTU_Text, "Чил-Аут 2");
        //            break;
        //        #endregion

        //        #region LoungeStairsAction
        //        case 15:
        //            //OptimizeCanvasFunc(RTU_LoungeCanvasItems, 1);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Вxод в Институт");
        //            break;
        //        case 7:
        //            #region BackUpStringsForSplittingFloors
        //            // foreacFloor
        //            // This One is 1st
        //            // 2nd - 26 - if(..==1){} if(..==3){}
        //            // 3d - 34 - if(..==2){} if(..==4) {}
        //            // 4th - 41 if(..=3){..5}
        //            //if (LoungeStairs.LoungeWhichFloor == 0)
        //            //    OptimizeCanvasFunc(RTU_LoungeCanvasItems, 2);
        //            //else if (LoungeStairs.LoungeWhichFloor == 2)
        //            //    OptimizeCanvasFunc(RTU_LoungeCanvasItems, 2);
        //            //else

        //            #endregion
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Фойе Института");
        //            break;
        //        case 26:
        //            //OptimizeCanvasFunc(RTU_LoungeCanvasItems, 3);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Этаж 2");
        //            break;
        //        case 34:
        //            //OptimizeCanvasFunc(RTU_LoungeCanvasItems, 4);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Этаж 3");
        //            break;
        //        case 41:
        //            //RTU_CanvasItems[0].SetActive(false);// without this RTU_Canvas shows at the RTU_LoungeCanvasItem  
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Этаж 4");
        //            break;
        //        #endregion

        //        #region Hall_3
        //        case 3:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Коридор администрации");
        //            break;
        //        case 13:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Коридор администрации");
        //            break;
        //        case 21:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Коридор администрации");
        //            break;
        //        #endregion

        //        #region ClassRooms
        //        case 4:
        //            //OptimizeCanvasFunc(RTU_ClassroomsCanvasItems, 1);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Компьютерный класс 239А");
        //            break;
        //        case 22:
        //            //OptimizeCanvasFunc(RTU_ClassroomsCanvasItems, 3);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Компьютерный класс 256");
        //            break;
        //        case 29:
        //            //OptimizeCanvasFunc(RTU_ClassroomsCanvasItems, 2);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Компьютерный класс 251А");
        //            break;
        //        case 39:
        //            //OptimizeCanvasFunc(RTU_ClassroomsCanvasItems, 4);
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Переговорный кабинет");
        //            break;
        //        #endregion

        //        #region Refectory
        //        case 5:
        //            RTU_Canvas.SetActive(true);
        //            RTU_Text.SetText("Кафетерий");
        //            break;
        //        case 25:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Обеденный зал");
        //            break;
        //        case 36:
        //            RTU_Canvas.SetActive(true);
        //            RTU_Text.SetText("Студенческая столовая — вход");
        //            break;
        //        #endregion

        //        #region SCR
        //        case 17:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Зал ученого совета — вид слева");
        //            break;
        //        case 43:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Зал ученого совета — вид справа");
        //            break;
        //        #endregion

        //        #region FTI
        //        case 2:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория специальных полимерных композитов кафедры оптических и биотехнический систем и технологий");
        //            break;
        //        case 16:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория прецизионной обработки материалов кафедры оптических и биотехнический систем и технологий");
        //            break; 
        //        case 19:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория механических испытаний материалов кафедры физики и химиии материалов им. Б.А. Догадкина");
        //            break;
        //        case 23:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория структурного анализа материалов кафедры физики и химиии материалов им. Б.А. Догадкина");
        //            break;
        //        case 27:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория цифровых технологий кафедры цифровых и аддитивных технологий");
        //            break;
        //        case 31:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Учебная лаборатория электроники кафедры электроники");
        //            break;
        //        case 35:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Учебная лаборатория электроники кафедры электроники");
        //            break;
        //        case 38:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Учебная лаборатория электроники кафедры электроники");
        //            break;
        //        case 44:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Учебная лаборатория электроники кафедры электроники");
        //            break;
        //        #endregion

        //        #region IKBSP
        //        case 1:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория автоматизированных систем в защищенном исполнении");
        //            break;
        //        case 14:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория \"Интеллектуальные сенсорные системы\"");
        //            break;
        //        case 32:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория оптико-электронных приборов и систем специального назначения");
        //            break;
        //        case 33:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лаборатория  программно-аппаратных средств защиты информации");
        //            break;
        //        case 42:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Специализированный компьютерный класс кафедры ценнообразования");
        //            break;
        //        #endregion

        //        #region IEP
        //        case 8:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Электронный ТИР");
        //            break;
        //        case 12:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лингафонный кабинет ");
        //            break;
        //        case 40:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Электронный ТИР");
        //            break;
        //        case 46:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Лингафонный кабинет ");
        //            break;
        //        #endregion

        //        #region SC
        //        case 6:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Бассейн");
        //            break;
        //        case 10:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Большой спортивный зал");
        //            break;
        //        case 11:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Тренажёрный зал");
        //            break;
        //        case 18:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Зал настольного тенниса");
        //            break;
        //        case 24:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Проход в Зал");
        //            break;
        //        case 28:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Зал гимнастики");
        //            break;
        //        case 45:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Многофункциональный зал");
        //            break;
        //        case 48:
        //            OptimizeCanvasFunc(RTU_Canvas, RTU_Text, "Зал Кросс-Фита");
        //            break;
        //        #endregion


        //        case 20:

        //            break;

        //    }
    }


    private void OptimizeCanvasFunc(GameObject CanvasItem,TextMeshProUGUI UI_Text,string text)
    {
        CanvasItem.SetActive(true);
        UI_Text.SetText(text);
    }

    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Escape.ToString())) && !_backToCube)
        {
            BackToCube();
        }//optimizable
    }

    public void BackToCube()
    {
        //    SceneManager.UnloadSceneAsync("Main");
        //SceneManager.LoadSceneAsync("Main");
        UI_MainSceneCanvas.SetActive(true);
        UI_PanoramSceneCanvas.SetActive(false);
        UI_ImageBackground.SetActive(false);
        NavDown.SetActive(false);
        NavUp.SetActive(false);
        PannelNavigation.SetActive(false);
        teleportRefectory[0].SetActive(false);
        teleportRefectory[1].SetActive(false);

        MainSceneObjects.SetActive(true);
        PanoramSceneObjects.SetActive(false);
        PlanesActions.DoNotUseSomeStringsInCubeChangeSky = true;
        RenderSettings.skybox = Default;
        FieldOfView.zoom = false; // static var in FieldOfView script
        Camera.main.transform.localEulerAngles = new Vector3(35, 0, 0);
        Camera.main.GetComponent<CamMouseLock>().enabled = false;
    }


  
}





