using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemies : MonoBehaviour
{
    public GameObject finalCanv;
    public GameObject road;
    private moveroad mov;

    public float currentScore;
    public float bestScore;

    public void Start()
    {
        mov = road.GetComponent<moveroad>();
        currentScore = mov.curScore;
        bestScore = PlayerPrefs.GetFloat("bestScore");

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.gameObject.tag == "Player"))
            PlayerPrefs.SetFloat("curScore", currentScore);
              if (bestScore > currentScore)
              {
                PlayerPrefs.SetFloat("bestScore",currentScore);
              }
        SceneManager.LoadScene(3);
    }
}
