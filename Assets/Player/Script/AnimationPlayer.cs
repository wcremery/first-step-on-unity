using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour {

    public Transform shoulder;

    private Animator animator;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        animator.SetBool("isWalking", false);

        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            animator.SetBool("isWalking", true);
        }

        if (animator.GetBool("isWalking") && Input.GetButtonDown("Fire3"))
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", true);
        }

        if(animator.GetBool("isRunning") && Input.GetButtonUp("Fire3"))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
