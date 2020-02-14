using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWeapon : MonoBehaviour {

    public AudioSource weaponReloading;

    private Animator anim;

	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            weaponReloading.Play();
            anim.SetTrigger("Reload");
        }	
	}
}
