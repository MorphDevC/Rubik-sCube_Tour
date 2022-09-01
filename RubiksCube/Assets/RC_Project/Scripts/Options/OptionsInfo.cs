using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OptionsInfo:MonoBehaviour
{
    private List<ISliderInfo> _options;
    private void Start()
    {
        _options = GetComponentsInChildren<ISliderInfo>().ToList();
    }

    public void RegisterOptionalValue(PropertyTag targetTag, IOptionableValue referenceValue)
    {
        foreach (var option in _options)
        {
            //if(option.GetTargetTag.Equals(targetTag))
                //option.OnOptionValueChange+=referenceValue.Value
        }
    }
}
