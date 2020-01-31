using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControl : MonoBehaviour
{
    public bool toPerspective = false;
    public bool startMovement = false;
    public MapRotator mapRotator;
    public MapMovement mapMovement;

    private void OnEnable()
    {
        if (toPerspective)
        {
            mapRotator.ToPerspective();
        }
        else
        {
            mapRotator.ToTop();
        }

        if (startMovement)
        {
            mapMovement.MapStart();
        }
        else
        {
            mapMovement.MapStop();
        }
    }
}
