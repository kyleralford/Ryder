using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAnimator : MonoBehaviour
{
	public StringReference onEnableAnimation;
    public FloatReference animationBeginTime;
	private Animator animator;
    private float timer;

	void Awake()
	{
		animator = gameObject.GetComponent<Animator>();
	}

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > animationBeginTime.Value)
        {
            animator.SetTrigger(onEnableAnimation.Value);

            timer = 0;

            enabled = false;
        }
    }
}
