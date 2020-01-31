using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotator : MonoBehaviour
{
    private Animator animator;
    private bool isTop = true;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void ToPerspective()
    {
        if (isTop)
        {
            animator.SetTrigger("ToPersp");
            isTop = false;
        }
    }

    public void ToTop()
    {
        if (!isTop)
        {
            animator.SetTrigger("ToTop");
            isTop = true;
        }
    }
}
