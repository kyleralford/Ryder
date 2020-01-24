using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnFunctionCallListener : MonoBehaviour
{
    public bool triggerOnAwake;
    public bool triggerOnEnable;
    public bool triggerOnStart;
    public UnityEvent response;

    private void Awake()
    {
        if (triggerOnAwake)
        {
            response.Invoke();
        }
    }

    private void OnEnable()
    {
        if (triggerOnEnable)
        {
            response.Invoke();
        }
    }

    void Start()
    {
        if (triggerOnStart)
        {
            response.Invoke();
        }
    }
}
