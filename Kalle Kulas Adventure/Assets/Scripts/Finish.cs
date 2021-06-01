using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){ //Om man går in i första flaggan kommer man til level 2.
        if(other.transform.tag == "Finish"){
            Debug.Log("Congratulations!! You Finished Level 1!");
            SceneManager.LoadScene(2);
        }
    }
}
