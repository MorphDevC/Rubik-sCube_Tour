using UnityEngine;

public class ObjectTwirlingFloat:MonoBehaviour
{
    [SerializeField] private OptionsInfo OptionsInfoReference;
    [SerializeField] private PropertyTag _propertyTag;
    
    private IOptionableValue<float> _twirlingValue;
    
    public virtual void Start()
    {
        SetOptionalValue();
    }
    
    private void SetOptionalValue()
    {
        _twirlingValue = OptionsInfoReference != null ? new OptionalValueFloat(OptionsInfoReference.GetDefaultValue(_propertyTag)) : new OptionalValueFloat(3f);
        OptionsInfoReference.RegisterFloatOptionalValue(_propertyTag, _twirlingValue);
    }

    public float GetTwirlingValue => _twirlingValue.OptionalValue;
}
