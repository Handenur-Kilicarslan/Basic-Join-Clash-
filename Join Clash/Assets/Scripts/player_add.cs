using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_add : MonoBehaviour
{
    public PlayerMovement movement;
    public PlayerMovement movementC1;
    public PlayerMovement movementC2;

    public stateController state;
    public stateController stateC1;
    public stateController stateC2;

    public Material PlayerColor;
    public GameObject govde1;
    public GameObject govde2;
    public GameObject govde3;


    Animator animator; //animasyona erişmek için 
    int isWalkingHash;

    void Start()
    {
        animator = GetComponent<Animator>(); //Get the component
        isWalkingHash = Animator.StringToHash("IsWalking");

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Clone_person")
        {
            // other.gameObject.transform.GetChild(0).GetComponent<Renderer>().material = PlayerColor;
            govde1.GetComponent<Renderer>().material = PlayerColor;
            govde2.GetComponent<Renderer>().material = PlayerColor;
            govde3.GetComponent<Renderer>().material = PlayerColor;

            Debug.Log("Bir obstacle ile çarpıştık");
            movement.enabled = true;  //playermovement scripti enabled
            state.enabled = true;

            movementC1.enabled = true;
            stateC1.enabled = true;

            movementC2.enabled = true;
            stateC2.enabled = true;   
            
        }

        



        if (other.collider.tag == "clonecluster2")
        {
            movement.enabled = true;  //playermovement scripti enabled
            state.enabled = true;

            movementC1.enabled = true;
            stateC1.enabled = true;
            

        }
        //collider yerine gameobject dene


       

    }
}



