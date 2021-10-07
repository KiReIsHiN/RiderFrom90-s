using UnityEngine;
using GameParametr;
using PlayControllerLevel;

public class EnemyMove : MonoBehaviour 
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Player"))
        {
            if (GameParametrs.hasProtect == false)
            {
                GameParametrs.hp -= 33;
                Destroy(gameObject);
            }
            else
            {
                GameParametrs.hasProtect = false;
                Destroy(gameObject);
            }
        }
    }

}
