using System;
using TMPro;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;


[RequireComponent(typeof(Slider))]
public class SliderInfo:MonoBehaviour,ISliderInfo
{
    public event Action<float> OnOptionValueChange;
    public float GetCurrentValue { get; private set; }
    public float GetMinValue { get; private set; }
    public float GetMaxValue { get; private set;}
    public PropertyTag GetTargetTag { get; private set; }
    
    [SerializeField] private PropertyTag _targetPropertyTag;
    [SerializeField] private TextMeshProUGUI _value;

    private void Awake()
    {
        _localSliderComponent = GetComponent<Slider>();
        SetDefaultValues(_localSliderComponent,_value,_targetPropertyTag);
        _localSliderComponent.onValueChanged.AddListener(ChangeValue);
    }
    

    private void SetDefaultValues(Slider targetSlider,TextMeshProUGUI targetText,PropertyTag targetTag)
    {
        if(targetSlider ==null)
            return;
        GetMinValue = targetSlider.minValue;
        GetCurrentValue = targetSlider.value;
        GetMaxValue = targetSlider.maxValue;
        _differenceMaxMinValue = GetMaxValue - GetMinValue;
        targetText.text = CalculatePercentages(GetCurrentValue).ToString("P0");
        GetTargetTag = targetTag;
    }

    private void ChangeValue(float value)
    {
        GetCurrentValue = value;
        OnOptionValueChange?.Invoke(GetCurrentValue);
        if(_value!=null)
            _value.text = CalculatePercentages(value).ToString("P0");
    }

    private float CalculatePercentages(float value)
    {   
        return (value - GetMinValue) / _differenceMaxMinValue;
    }

    private Slider _localSliderComponent = null;
    private float _differenceMaxMinValue;
}
