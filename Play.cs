using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Play : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene("Demo-Level");
    }
}
