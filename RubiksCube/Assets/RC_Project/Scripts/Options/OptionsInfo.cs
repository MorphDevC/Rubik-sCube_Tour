using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OptionsInfo:MonoBehaviour
{
    private List<ISliderInfo> _options;
    private void Awake()
    {
        _options = GetComponentsInChildren<ISliderInfo>().ToList();
    }

    public float GetDefaultValue(PropertyTag targetTag)
    {
        return _options.First(option => option.GetTargetTag.Equals(targetTag)).GetCurrentValue;
    }

    public void RegisterFloatOptionalValue(PropertyTag targetTag, IOptionableValue<float> referenceValue)
    {
        _options.First(option => option.GetTargetTag.Equals(targetTag)).OnOptionValueChange += referenceValue.SetValue;
    }
}
