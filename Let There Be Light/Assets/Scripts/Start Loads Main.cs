using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLoadsMain : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("MainScene");
    }
}
