using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour{

    public GameObject pauseMenu;
    public bool isPaused;

    void Start(){
        isPaused = false;
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape))
            togglePause();
    }

    public void togglePause() {
        if (pauseMenu) {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0f : 1f;
        }
    }

    public void restartGame() {
        SceneManager.LoadScene(1);
        togglePause();
    }

    public void changeScene() {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(0);
        togglePause();
    }
}
