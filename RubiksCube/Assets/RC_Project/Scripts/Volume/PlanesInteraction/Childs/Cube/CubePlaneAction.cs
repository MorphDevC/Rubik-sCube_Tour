using System;

public class CubePlaneAction:PlaneAction
{
    private bool _mouseOnPlane = false;

    public override void Awake()
    {
        base.Awake();
        PlaneNumber = Convert.ToByte(gameObject.name.Substring(5));
    }

    public override void OnMouseEnter()
    {
        _mouseOnPlane = true;
        base.OnMouseEnter();
    }

    public override void OnMouseExit()
    {
        _mouseOnPlane = false;
        base.OnMouseExit();
    }

    public override void OnMouseUp()
    {
        if (_mouseOnPlane)
        {
            base.OnMouseUp();
        }
    }
}
