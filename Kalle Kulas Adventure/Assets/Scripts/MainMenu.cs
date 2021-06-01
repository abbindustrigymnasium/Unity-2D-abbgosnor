using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour // Main menu scriptet för alla knappar.
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Quitgame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void Level1(){
        SceneManager.LoadScene(1);
    }
    public void Level2(){
        SceneManager.LoadScene(2);
    }
}
