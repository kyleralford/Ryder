using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventTimer : MonoBehaviour
{
    [Tooltip("Delay, in seconds")]
    public FloatReference delay;
    public UnityEvent Event;
    private float timer;
    
    public void ExecuteEvent()
    {
        Event.Invoke();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay.Value)
        {
            ExecuteEvent();
            timer = 0;
        }
    }
}
