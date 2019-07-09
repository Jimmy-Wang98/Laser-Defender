using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LaadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void StopSpel()
    {
        Application.Quit();
    }
}