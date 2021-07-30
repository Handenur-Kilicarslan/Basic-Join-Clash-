using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager2 : MonoBehaviour
{

    public GameObject OyunBoyuUI;
    public GameObject winUI;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "finishObject")
        {
            OyunBoyuUI.SetActive(false);
            winUI.SetActive(true);
        }
    }
}

