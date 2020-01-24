using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableAnimator : MonoBehaviour
{
	public StringReference onEnableAnimation;
	private Animator animator;

	void Awake()
	{
		animator = gameObject.GetComponent<Animator>();
	}

    private void OnEnable()
    {
        animator.SetTrigger(onEnableAnimation.Value);
    }
}
