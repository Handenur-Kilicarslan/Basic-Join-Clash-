using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class devamkodu : MonoBehaviour
{
    public void butondeneme()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
