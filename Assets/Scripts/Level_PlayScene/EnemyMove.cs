using UnityEngine;
using GameParametr;

public class EnemyMove : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Удар");
            GameParametrs.hp -= 33;
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0f, GameParametrs.speed, 0f);

        if (transform.position.y <= -11)
            Destroy(gameObject);
    }
}
