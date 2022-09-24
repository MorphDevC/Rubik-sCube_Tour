using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(CanvasRenderer))]
public class DestinationText:MonoBehaviour, IDestinationText
{
    private CanvasGroup _canvasGroup;
    private TextMeshProUGUI _textObject;
    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _textObject = GetComponentInChildren<TextMeshProUGUI>(); // may be error
    }

    public void ShowDestination(string targetText)
    {
        _textObject.SetText(targetText);
        _canvasGroup.alpha = 1f;
    }

    public void HideDestination()
    {
        _canvasGroup.alpha = 0f;
    }
    
}
