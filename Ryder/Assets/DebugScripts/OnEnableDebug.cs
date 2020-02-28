using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableDebug : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log(gameObject.name + " was Enabled at time " + Time.time);
    }
}
