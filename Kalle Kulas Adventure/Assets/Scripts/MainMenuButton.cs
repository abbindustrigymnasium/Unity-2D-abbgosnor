using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour //Main menu knappen i spelet.
{
    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
