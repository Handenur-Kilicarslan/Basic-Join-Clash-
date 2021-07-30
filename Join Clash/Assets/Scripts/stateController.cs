using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateController : MonoBehaviour
{
    Animator animator; //animasyona erişmek için 
    int isWalkingHash;

    void Start()  //THIS PART WORK WHEN THE GAME STARTS
    {
        animator = GetComponent<Animator>(); //Get the component
        isWalkingHash = Animator.StringToHash("IsWalking");
    }
    
    void Update()
    {
        bool IsWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = (Input.GetKey("w"));

        // if player pressed w and not walking
        if (!IsWalking && forwardPressed)  // if player pressed w and not walking
        {
            //isWalking boolean değeri true atanır
            animator.SetBool(isWalkingHash, true);  //isWalking boolean değeri true atanır
        }

        //if player not pressing w and walking
        if (IsWalking && !forwardPressed) 
        {
            //isWalking boolean değeri false atanır
            animator.SetBool(isWalkingHash, false);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "finishObject")
        {
            animator.SetBool("Dancing", true);
        }
    }
}
