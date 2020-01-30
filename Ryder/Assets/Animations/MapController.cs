using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    private Animator animator;
    private bool isTop;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        isTop = true;
    }

    public void ToPerspective()
    {
        if (isTop)
        {
            animator.SetTrigger("ToPersp");
        }
    }

    public void ToTop()
    {
        if (!isTop)
        {
            animator.SetTrigger("ToTop");
        }
    }
}
