using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanoramaBehaviour : MonoBehaviour
{
    public event Action OnPanoramaSetCamera;
    public event Action OnPanoramaUnSetCamera;
    public event Action<BelongableTag,bool, byte> OnPanoramaSetOwnedObjects;
    public event Action<BelongableTag,bool> OnPanoramaUnSetOwnedObjects;
    
    [SerializeField] private List<ManagerPlaneAction> _planeActionManagerRef;
    
    private string bundleURL;
    public Texture2D for_loading;
    private int version = 0;



    [Header("Panoram Objects")]
    public Material UniversalMat;
    public Shader Panorama;
    public Renderer m_Renderer;

    private Shader _defaultShader;
    
    
    private NumberPanelPanorama _panoramaSuppInfo = new NumberPanelPanorama();

    private void Start()
    {
#if !UNITY_EDITOR
bundleURL = Application.absoluteURL + "AssetBundles/";
#else
bundleURL = "http://morph977.site/RC2/AssetBundles/";
#endif
        if(_planeActionManagerRef !=null)
        {
            _planeActionManagerRef.ForEach(mgr=>mgr.RegisterFuncOnPlaneSelected(ChangePanorama));
        }

        _defaultShader = gameObject.GetComponent<Renderer>().material.shader;
    }

    public void ChangePanorama(byte targetIdPlane)
    {
        OnPanoramaSetOwnedObjects?.Invoke(BelongableTag.Panorama,true, targetIdPlane);
        StartCoroutine(DownloadCacheView(_panoramaSuppInfo.TargetPanoramaToLoad[targetIdPlane]));
    }

    private IEnumerator DownloadCacheView(string name)
    {
        m_Renderer = GetComponent<Renderer>();
        UniversalMat.mainTexture = for_loading;
        UniversalMat.shader = Panorama;
        m_Renderer.material = UniversalMat;
    
        while (!Caching.ready)
            yield return null;
        
        var www = WWW.LoadFromCacheOrDownload(bundleURL + name, version);
        yield return www;
        
        if (!string.IsNullOrEmpty(www.error))
            yield break;
        
        var assetBundle = www.assetBundle;
        var imageRequest = assetBundle.LoadAssetAsync(name + ".jpg", typeof(Texture2D));
        yield return imageRequest;
        
        m_Renderer = GetComponent<Renderer>();
        UniversalMat.mainTexture = imageRequest.asset as Texture2D;
        UniversalMat.shader = Panorama;
        m_Renderer.material = UniversalMat;
        assetBundle.Unload(false);
        
        OnPanoramaSetCamera?.Invoke();
    }
    

    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Escape.ToString())))
            BackToCube();
    }

    public void BackToCube()
    {
        OnPanoramaUnSetCamera?.Invoke();
        OnPanoramaUnSetOwnedObjects?.Invoke(BelongableTag.Cube,true);
        UniversalMat.shader =  _defaultShader;
    }

    private IEnumerator DownloadCacheViewLocal(string name)
    {
        Texture2D _texture = Resources.Load<Texture2D>(name);
        m_Renderer = GetComponent<Renderer>(); 
        UniversalMat.mainTexture = _texture; 
        UniversalMat.shader = Panorama;
        m_Renderer.material = UniversalMat;
        yield return null;
    }
}





