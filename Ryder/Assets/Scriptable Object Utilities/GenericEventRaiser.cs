using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericEventRaiser : MonoBehaviour
{
    public GameEvent gameEvent;

    public void RaiseEvent()
    {
        gameEvent.Raise();
    }
}
