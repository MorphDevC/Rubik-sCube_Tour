public interface ISliderInfo
{
    float GetCurrentValue { get; }
    float GetMinValue { get; }
    float GetMaxValue { get; }
    PropertyTag GetTargetTag { get; }
}
