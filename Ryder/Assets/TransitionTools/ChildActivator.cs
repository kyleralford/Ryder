using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildActivator : MonoBehaviour
{
    public BoolReference activeOnAwake;
    public BoolReference activeOnEnable;
    public BoolReference activeOnStart;
    public BoolReference inactiveOnAwake;
    public BoolReference inactiveOnEnable;
    public BoolReference inactiveOnStart;
    private Coroutine delayCoroutine;

	void Awake()
    {
        if (activeOnAwake.Value)
        {
            ChildrenSetActive();
        }
        else if (inactiveOnAwake.Value)
        {
            ChildrenSetInactive();
        }
    }

    private void OnEnable()
    {
        if (activeOnEnable.Value)
        {
            ChildrenSetActive();
        }
        else if (inactiveOnEnable.Value)
        {
            ChildrenSetInactive();
        }
    }

    void Start()
	{
        if (activeOnStart.Value)
        {
            ChildrenSetActive();
        }
        else if (inactiveOnStart.Value)
        {
            ChildrenSetInactive();
        }
    }

    public void ChildrenSetActive()
    {
        // Stop the inactive delay coroutine, if running
        if (delayCoroutine != null)
        {
            StopCoroutine(delayCoroutine);
        }

        // Activate children
		foreach (Transform child in transform)
		{
            child.gameObject.SetActive(true);
		}
	}

	public void ChildrenSetInactive()
	{
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void ChildrenSetInactiveDelay(float delay)
    {
        delayCoroutine = StartCoroutine(ChildrenSetInactiveDelayCoroutine(delay));
    }

    IEnumerator ChildrenSetInactiveDelayCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);
        ChildrenSetInactive();
    }

    public void ChildrenResetActive()
    {
        // Stop the inactive delay coroutine, if running
        if (delayCoroutine != null)
        {
            StopCoroutine(delayCoroutine);
        }

        // Reset active state
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeSelf == true)
            {
                child.gameObject.SetActive(false);
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
