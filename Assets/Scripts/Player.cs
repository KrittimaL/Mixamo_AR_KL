using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //Debug.Log("eiei");

        if (Input.GetKey(KeyCode.A)){
            Debug.Log("A");
            //if key 1 is pressed, then change the animation
            animator.SetInteger("dance", 1);
        }
        if (Input.GetKey(KeyCode.B)){
            Debug.Log("B");
            //if key 2 is pressed, then change the animation
            animator.SetInteger("dance", 2);
        }
        if (Input.GetKey(KeyCode.C)){
            Debug.Log("C");
            //if key 3 is pressed, then change the animation
            animator.SetInteger("dance", 3);
        }


    }
}
