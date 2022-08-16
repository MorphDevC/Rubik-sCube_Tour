using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationRefectory
{
    public static void SetNavRefectory
    (
        GameObject exactlySetTrue_GameObj,
        GameObject mightSetTrue_GameObj,
        Vector3 exactlyPositionGameObj,
        byte RefectoryPosition
    )
    {

        exactlySetTrue_GameObj.SetActive(true); // NavUp
        mightSetTrue_GameObj.SetActive(false);
        exactlySetTrue_GameObj.transform.localPosition = exactlyPositionGameObj;
        TeleportAction.RefPos = RefectoryPosition;
        //L= Load StreamingAssets SkyBox
    }

    public static void SetNavRefectory
    (
        GameObject exactlySetTrue_GameObj,
        GameObject mightSetTrue_GameObj,
        Vector3 exactlyPositionGameObj,
        Vector3 mightPositionGameObj,
        byte RefectoryPosition
    )
    {
        exactlySetTrue_GameObj.SetActive(true);
        mightSetTrue_GameObj.SetActive(true);
        exactlySetTrue_GameObj.transform.localPosition = exactlyPositionGameObj;
        mightSetTrue_GameObj.transform.localPosition = mightPositionGameObj;
        TeleportAction.RefPos = RefectoryPosition;// false = left and right
        //L= Load StreamingAssets SkyBox
    }
}
