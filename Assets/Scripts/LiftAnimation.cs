using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftAnimation : MonoBehaviour
{
    private Animator animator;
    private bool animationPlayed;
    public bool buttonPressed;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
        animationPlayed = false;
        buttonPressed = false;
    }

    void Update()
    {
        if (!animationPlayed && buttonPressed)
        {
            animator.enabled = true;
            animationPlayed = true;
        }
    }

}
