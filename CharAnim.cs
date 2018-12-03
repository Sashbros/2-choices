using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnim : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (GameObject.Find("Char").GetComponent<CharMovement>().isGrounded == false)
                anim.SetBool("kick", true);
        }
        else
        {
            anim.SetBool("kick", false);
        }
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    anim.SetBool("punch", true);
        //}
        //else
        //{
        //    anim.SetBool("punch", false);
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameObject.Find("Char").GetComponent<CharMovement>().isGrounded == true)
                anim.SetTrigger("jump");
        }
    }
}
