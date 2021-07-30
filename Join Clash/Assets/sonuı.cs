using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonuı : MonoBehaviour
{

    public GameObject OyunBoyuUI;
     public GameObject winUI;
     public GameObject particle;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "finishObject")
        {

            OyunBoyuUI.SetActive(false);
            winUI.SetActive(true);
            particle.SetActive(true);
        }
    }

}
