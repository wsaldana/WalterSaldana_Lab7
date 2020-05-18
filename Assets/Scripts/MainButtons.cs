using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour{
    
    public void changeScene() {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(0);
    }

    public void quitGame() {
        Debug.Log(" - QUIT GAME - ");
        Application.Quit();
    }
}
