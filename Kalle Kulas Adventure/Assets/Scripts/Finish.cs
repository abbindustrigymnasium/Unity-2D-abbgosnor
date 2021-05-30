using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Finish"){
            Debug.Log("Congratulations!! You Finished Level 1!");
            SceneManager.LoadScene(2);
        }
    }
}
