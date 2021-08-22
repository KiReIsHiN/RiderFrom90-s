using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Results : MonoBehaviour {

    float curScore, bestScore;// переменные для хранения расстояния и рекорда

    public Text curentScore;
    public Text btScore;

    public float speed;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;

    void Start () {
        curScore = PlayerPrefs.GetFloat("curScore", curScore); //Извлекаем переменну нашего счета из глобальных данных
        bestScore = PlayerPrefs.GetFloat("bestScore", bestScore); //Извлекаем переменну лучшего счета из глобальных данных
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        curentScore.text = Mathf.RoundToInt(curScore*-1) + " " + "m".ToString();
        btScore.text = Mathf.RoundToInt(bestScore*-1) + " " + "m".ToString();


        car1.transform.Translate(new Vector3(0f, speed, 0f));
        car2.transform.Translate(new Vector3(0f, speed, 0f));
        car3.transform.Translate(new Vector3(0f, speed, 0f));
        car4.transform.Translate(new Vector3(0f, speed, 0f));


        if (car1.transform.position.x > 17f)
        {
            car1.transform.position = new Vector3(-17f, car1.transform.position.y, car1.transform.position.z);
        }

        if (car2.transform.position.x > 17f)
        {
            car2.transform.position = new Vector3(-17f, car2.transform.position.y, car2.transform.position.z);
        }

        if (car3.transform.position.x < -17f)
        {
            car3.transform.position = new Vector3(17f, car3.transform.position.y, car3.transform.position.z);
        }

        if (car4.transform.position.x < -17f)
        {
            car4.transform.position = new Vector3(17f, car4.transform.position.y, car4.transform.position.z);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
