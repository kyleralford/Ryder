using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAnimator : MonoBehaviour
{
    public StringReference onEnableAnimation;
    public StringReference onDisableAnimation;
    public FloatReference animationBeginTime;
    private Animator animator;
    private float timer;
    private bool updateRunning;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        updateRunning = true;
    }

    private void OnEnable()
    {
        updateRunning = true;
    }

    void Update()
    {
        if (updateRunning == true)
        {
            timer += Time.deltaTime;

            if (timer > animationBeginTime.Value)
            {
                animator.SetTrigger(onEnableAnimation.Value);

                timer = 0;

                updateRunning = false;

            }
        }
    }
}