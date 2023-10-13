using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftAnimation : MonoBehaviour
{
    private Animator animator;
    private bool animationPlayed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
        animationPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!animationPlayed && Input.GetMouseButtonDown(0))
        {
            animator.enabled = true;
            animationPlayed = true;
        }
    }
}
