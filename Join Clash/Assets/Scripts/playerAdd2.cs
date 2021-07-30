using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAdd2 : MonoBehaviour
{
    public PlayerMovement m1;
    public PlayerMovement m2;

    public stateController s1;
    public stateController s2;

    public Material PlayerColor;
    public GameObject govde1;
    public GameObject govde2;

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "clonecluster1")
        {

            govde1.GetComponent<Renderer>().material = PlayerColor;
            govde2.GetComponent<Renderer>().material = PlayerColor;

            m1.enabled = true;
            s1.enabled = true;

            m2.enabled = true;
            s2.enabled = true;
        }
    }
}
