using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMove : MonoBehaviour {

    public Vector2 dir;

    public GameObject road;
    private moveroad mov;
    public float speed;

    void Start () {
        mov = road.GetComponent<moveroad>();
        speed = mov.speed;
	}
	
	void FixedUpdate () {
        transform.Translate(0f,speed,0f);
	}
}
