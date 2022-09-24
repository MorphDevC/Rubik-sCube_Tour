using System.Collections;
using UnityEngine;

public static class RendererExt
{
    public static void EnableEmission(this Renderer targetRenderer)
    {
        targetRenderer.material.EnableKeyword("_EMISSION");
    }
    public static void DisableEmission(this Renderer targetRenderer)
    {
        targetRenderer.material.DisableKeyword("_EMISSION");
    }
    
    public static IEnumerator DelayEmission(this Renderer targetRenderer, float time)
    {
        yield return new WaitForSeconds(time);
        targetRenderer.material.DisableKeyword("_EMISSION");
    } 
    public static void DelayEmission(this Renderer targetRenderer)
    {
        targetRenderer.material.DisableKeyword("_EMISSION");
    } 
}
