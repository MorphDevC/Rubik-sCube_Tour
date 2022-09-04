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
    public event Action OnPanoramaSetCamera;
    public event Action OnPanoramaUnSetCamera;
    
    public event Action<BelongableTag,bool> OnPanoramaSetUI;
    public event Action<BelongableTag,bool> OnPanoramaUnSetUI;
    
    private string bundleURL;
    public Texture2D for_loading;
    private int version = 0;
    private int[] profilenumbers = new int[12];
    private int counter = 0;



    [Header("Panoram Objects")]
    public Material UniversalMat;
    public Shader Panorama;
    public Renderer m_Renderer;
    public Shader DefaultShader;

    [Header("GameObjects")]
    public GameObject NavUp;
    public GameObject NavDown;
    public GameObject PannelNavigation;
    public GameObject[] teleportRefectory = new GameObject[2];

    public GameObject MainSceneObjects;
    
    [Header("UI_GameObjects")]
    public GameObject UI_MainCubeCanvas;
    public GameObject UI_BackToCube_Panoram;
    [Header ("UI_Destinition")]
    public GameObject UI_ImageBackground;
    public TextMeshProUGUI UI_DestinitionText;


    private static Vector3 _vectorCameraAngles;
    private static bool _inChiillPannel;
    private bool _backToCube = false;

    private static Vector3 VectorCameraAngles { get => _vectorCameraAngles; set => _vectorCameraAngles = value; }
    public static bool InChiillPannel { get => _inChiillPannel; set => _inChiillPannel = value; } //for using 1 pannel for Classrooms and ChillOuts

    private NumberPanelPanorama _targetPanoramaName = new NumberPanelPanorama();



    private void Start()
    {
#if !UNITY_EDITOR
bundleURL = Application.absoluteURL + "AssetBundles/";
#else
bundleURL = "http://morph977.site/RC2/AssetBundles/";
#endif
    }
    



    public void ChangeSkyBox(byte WhichPlane)
    {
        
        if (!PlanesActions.DoNotUseSomeStringsInCubeChangeSky)
        {
            OnPanoramaSetUI?.Invoke(BelongableTag.Panorama,true);

            PlanesActions.DoNotUseSomeStringsInCubeChangeSky = true;

        }
        //}
        switch (WhichPlane)
        {
            #region ChilloutsAction
            case 9:

                StartCoroutine(DownloadCacheView("chillout1"));
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-150, 20, -60), new Vector3(-90, 0, -80), true);
                NavigationPannel.SetNavUpDownSpheresFalse(NavUp,NavDown);
                // 1st Vector = position
                // 2nd vector = localEulerAngles
                
                break;
            case 30:
                StartCoroutine(DownloadCacheView("chillout2"));
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-2, 25, 69), new Vector3(-90, 85, -90), true);
                NavigationPannel.SetNavUpDownSpheresFalse(NavUp, NavDown);
                break;
            case 37:
                StartCoroutine(DownloadCacheView("chillout3"));

                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(102, 20, 53), new Vector3(-90, 0, 33), true);
                NavigationSphere.SetNavUpDownSpheres(NavDown, NavUp, new Vector3(6, 34, -41), 8);
                break;
            case 47:
                StartCoroutine(DownloadCacheView("chillout4"));

                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-105, 35, -145), new Vector3(-90, 0, -127), true);
                NavigationPannel.SetNavUpDownSpheresFalse(NavUp, NavDown);
                
                break;
            #endregion

            #region LoungeStairsAction
            case 15:
                StartCoroutine(DownloadCacheView("loungestairs0"));

                //NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-22, 39, -36), 0);
                break;
            case 7:
                StartCoroutine(DownloadCacheView("loungestairs1"));

                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-14, 43, -88), new Vector3(23, 35, -69), 1);
                // go to LoungeStairsClass and set LoungeWhichFloor new val cuz in
                // switch case we watching at which floor but if we go on other floor
                // from main cube we have to change this var
                break;
            case 26:
                StartCoroutine(DownloadCacheView("loungestairs2"));

                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-29, 43, -76), new Vector3(-14, 27, -81), 2);

                break;
            case 34:
                StartCoroutine(DownloadCacheView("loungestairs3"));

                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(-27, 44, -59.5f), new Vector3(-7, 29, -41), 3);

                break;
            case 41:
                StartCoroutine(DownloadCacheView("loungestairs4"));
                PannelNavigation.SetActive(false);

                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(21, 34, -63), new Vector3(-22, 30, -51.8f), 4);

                break;
            #endregion

            #region Hall3
            case 3:
                StartCoroutine(DownloadCacheView("hall3_3"));

                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(22.5f, 36, -37), 7);
                //NavStairsSph.HallOrStair = 7; // to see decr look in LoungeStairs.cs
                break;
            case 13:
                StartCoroutine(DownloadCacheView("hall3_1"));

                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(20, 34, -87.5f), 5);
                break;
            case 21:
                StartCoroutine(DownloadCacheView("hall3_2"));

                NavigationSphere.SetNavUpDownSpheres(NavUp, NavDown, new Vector3(23, 36, -34), new Vector3(-29, 36, -93), 6);                    
                break;
            #endregion

            #region Classroom
            case 4:
                StartCoroutine(DownloadCacheView("239"));

                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(127.5f,37,-205), new Vector3(-90, 0, -180), false);
                //InChiillPannel = false;
                break;
            case 22:
                StartCoroutine(DownloadCacheView("256"));

                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(143,7,46), new Vector3(-90, 0, 16), false);
                break;
            case 29:
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(161, 35, -250), new Vector3(-90, 0, -180), false);

                StartCoroutine(DownloadCacheView("251a"));
                break;
            case 39:
                NavigationPannel.SetNavPannel(PannelNavigation, new Vector3(-33,22,-22), new Vector3(-90, 0, -70), false);

                StartCoroutine(DownloadCacheView("310"));
                break;
            #endregion

            #region Refectory
            case 5:
                NavigationRefectory.SetNavRefectory(teleportRefectory[1], teleportRefectory[0], new Vector3(377, 9, -147), 1);//leftView

                StartCoroutine(DownloadCacheView("refectoryleft_2"));
                break;
            case 25:
                NavigationRefectory.SetNavRefectory(teleportRefectory[0], teleportRefectory[1], new Vector3(148, 4, 10), 1);//RightView

                StartCoroutine(DownloadCacheView("refectoryright_3"));
                break;
            case 36: 
                NavigationRefectory.SetNavRefectory(teleportRefectory[0], teleportRefectory[1], new Vector3(355, -13, 20), new Vector3(148, 2, -11), 2);
                
                StartCoroutine(DownloadCacheView("refectorymiddle_1"));
                break;
            #endregion

            #region SCR_Room
            case 17:
                teleportRefectory[0].SetActive(true);
                teleportRefectory[0].transform.localPosition = new Vector3(390, 10, -50);
                TeleportAction.RefPos = 3; // 1 - left or right doesntmatter

                StartCoroutine(DownloadCacheView("societycounselroom1"));
                break;
            case 43:
                teleportRefectory[0].SetActive(true);
                teleportRefectory[0].transform.localPosition = new Vector3(110, 0, -84);
                TeleportAction.RefPos = 4; // 1 - left or right doe sntmatter

                StartCoroutine(DownloadCacheView("societycounselroom2"));
                // write a method
                break;
            #endregion

            #region FTI_SkyBoxes
            case 2:
                StartCoroutine(DownloadCacheView("2"));

                break;
            case 16:
                StartCoroutine(DownloadCacheView("127"));

                break;
            case 19:
                StartCoroutine(DownloadCacheView("186"));

                break;
            case 23:
                StartCoroutine(DownloadCacheView("190"));

                break;
            case 27:
                StartCoroutine(DownloadCacheView("256b"));

                break;
            case 31:
                StartCoroutine(DownloadCacheView("329"));

                break;
            case 35:
                StartCoroutine(DownloadCacheView("333"));

                break;
            case 38:
                StartCoroutine(DownloadCacheView("331_1"));

                break;
            case 44:
                StartCoroutine(DownloadCacheView("331_2"));

                break;
            #endregion

            #region IKBSP
            case 1:
                StartCoroutine(DownloadCacheView("13"));

                break;
            case 14:
                StartCoroutine(DownloadCacheView("111"));

                break;
            case 32:
                StartCoroutine(DownloadCacheView("183"));

                break;
            case 33:
                StartCoroutine(DownloadCacheView("281"));

                break;
            case 42:
                StartCoroutine(DownloadCacheView("320"));

                break;

            #endregion
            
            #region IEP
            case 8:
                StartCoroutine(DownloadCacheView("8"));

                break;
            case 12:
                StartCoroutine(DownloadCacheView("439"));

                break;
            case 40:
                StartCoroutine(DownloadCacheView("8"));

                break;
            case 46:
                StartCoroutine(DownloadCacheView("439"));

                break;

            #endregion

            // #region SC
            // case 6:
            //     StartCoroutine(DownloadCacheView("swpool"));
            //
            //     break;
            // case 10:
            //     StartCoroutine(DownloadCacheView("sp1"));
            //
            //     break;
            // case 11:
            //     StartCoroutine(DownloadCacheView("gym"));
            //
            //     break;
            // case 18:
            //     StartCoroutine(DownloadCacheView("ping2"));
            //
            //     break;
            // case 24:
            //     StartCoroutine(DownloadCacheView("hall"));
            //
            //     break;
            // case 28:
            //     StartCoroutine(DownloadCacheView("gymnast"));
            //
            //     break;
            // case 45:
            //     StartCoroutine(DownloadCacheView("ping1"));
            //
            //     break;
            // case 48:
            //     StartCoroutine(DownloadCacheView("judo"));
            //
            //     break;
            // #endregion
            
            case 20:
                //RenderSettings.skybox = Default;
                break;
            
        }
        StartCoroutine(DownloadCacheView(_targetPanoramaName.TargetPanoramaToLoad[Convert.ToInt32(WhichPlane)]));
    }

    private IEnumerator DownloadCacheView(string name)
    {
        Debug.Log(Camera.main.transform.localEulerAngles);
        m_Renderer = GetComponent<Renderer>();
        UniversalMat.mainTexture = for_loading;
        UniversalMat.shader = Panorama;
        m_Renderer.material = UniversalMat;
    
//#if !UNITY_EDITOR
            while (!Caching.ready)
                yield return null;


            var www = WWW.LoadFromCacheOrDownload(bundleURL + name, version);
            yield return www;

            if (!string.IsNullOrEmpty(www.error))
            {
                yield break;
            }
            var assetBundle = www.assetBundle;

            var imageRequest = assetBundle.LoadAssetAsync(name + ".jpg", typeof(Texture2D));
            yield return imageRequest;

            m_Renderer = GetComponent<Renderer>();

            UniversalMat.mainTexture = imageRequest.asset as Texture2D;
        
            UniversalMat.shader = Panorama;

            m_Renderer.material = UniversalMat;
            assetBundle.Unload(false);
            OnPanoramaSetCamera?.Invoke();
//#endif 
        
// #if !UNITY_EDITOR
//             Texture2D _texture = Resources.Load<Texture2D>(name);
//
//             m_Renderer = GetComponent<Renderer>();
//             UniversalMat.mainTexture = _texture;
//             UniversalMat.shader = Panorama;
//
//             m_Renderer.material = UniversalMat;
//             yield return null;
// #endif
    }

    public void ShowDestinationPlane(byte DestinText)
    {
        UI_ImageBackground.SetActive(true);
        UI_DestinitionText.text=ShowPlaneDestinition.SetNewText(DestinText);
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
        // MainSceneObjects.SetActive(true);
        // UI_MainCubeCanvas.SetActive(true);
        //
        //
        //
        // UI_BackToCube_Panoram.SetActive(false);
        // UI_ImageBackground.SetActive(false);
        // NavDown.SetActive(false);
        // NavUp.SetActive(false);
        // PannelNavigation.SetActive(false);
        // teleportRefectory[0].SetActive(false);
        // teleportRefectory[1].SetActive(false);

        PlanesActions.DoNotUseSomeStringsInCubeChangeSky = false;
        
        OnPanoramaUnSetCamera?.Invoke();
        OnPanoramaSetUI?.Invoke(BelongableTag.Cube,true);
        UniversalMat.shader = DefaultShader;
    }


  
}





