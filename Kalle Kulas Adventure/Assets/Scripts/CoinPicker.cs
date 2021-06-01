using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinPicker : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI textCoins;   // Koden på gubbben för att kunna plocka upp coins

    private void OnTriggerEnter2D(Collider2D other){
        if (other.transform.tag == "Coin"){
            coin ++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }

}
