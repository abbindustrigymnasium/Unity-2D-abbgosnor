using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Level2Finish"){
            Debug.Log("Congratulations!! You Finished The Game!!");
            SceneManager.LoadScene(0);
        }
    }
}
