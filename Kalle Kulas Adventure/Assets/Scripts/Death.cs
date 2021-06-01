using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
    public float CurrentY = 1;
    public float HighY = 1;
    // Start is called before the first frame update
    void Start()
    {
         CurrentY = GetComponent<Rigidbody2D>().position.y;
         HighY = CurrentY;
    }

    // Update is called once per frame
    void Update()
    {
         CurrentY = GetComponent<Rigidbody2D>().position.y; //Koden för att kalle ska dö av att falla.
        if (CurrentY > HighY){
             HighY = CurrentY;
        }
        if (CurrentY+12 <= HighY){
            Debug.Log("You Fell To Death...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D other){ //Kod för att Kalle ska dö av spikes
        if(other.transform.tag == "Spike"){
            Debug.Log("You Got Spiked...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}