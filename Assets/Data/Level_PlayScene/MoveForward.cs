using GameParametr;
using UnityEngine;

class MoveForward : MonoBehaviour
{
    public void FixedUpdate()
    {
        transform.Translate(0f, GameParametrs.speed, 0f);
    }
}
