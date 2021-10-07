using UnityEngine;
using GameParametr;

public class CoinPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            GameParametrs.coins++;
            GameParametrs.coinsToProtects++;
            Destroy(gameObject);
        }
    }

}
