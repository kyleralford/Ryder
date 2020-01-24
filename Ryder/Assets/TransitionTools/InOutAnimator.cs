using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOutAnimator : MonoBehaviour
{
	public StringReference animateInTrigger;
	public StringReference animateOutTrigger;
	private Animator animator;

	void Start()
	{
		animator = gameObject.GetComponent<Animator>();
	}

	public void AnimateIn()
	{
		animator.SetTrigger(animateInTrigger.Value);
	}

	public void AnimateOut()
	{
		animator.SetTrigger(animateOutTrigger.Value);
	}
}
