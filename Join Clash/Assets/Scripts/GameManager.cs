using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject loseUI;
    public GameObject OyunBoyuUI;
    public GameObject OyunStartUI;
    public GameObject winUI;
    public GameObject particle;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            OyunStartUI.SetActive(false);
            OyunBoyuUI.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "finishObject")
        {
            OyunBoyuUI.SetActive(false);
            winUI.SetActive(true);
            particle.SetActive(true);
        }

        if (collision.collider.tag == "Engel")
        {
            OyunBoyuUI.SetActive(false);
            loseUI.SetActive(true);
        }

    }
}
