using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            animator.SetInteger("state", 2);
        }
        if (Input.GetKey("d"))
        {
            animator.SetInteger("state", 0);
        }
        if (Input.GetKey("e"))
        {
            animator.SetInteger("state", 1);
        }
        if (Input.GetKey("q")) { 
            animator.SetInteger ("state", 3);
        }
    }
}
