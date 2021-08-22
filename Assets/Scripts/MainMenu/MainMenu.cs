using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text score;
    public Slider volume;

    float bestScore;
    public float speed;

    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;

    // Use this for initialization
    void Start() {
        bestScore = PlayerPrefs.GetFloat("bestScore", bestScore); //Извлекаем переменну лучшего счета из глобальных данных 
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    private void FixedUpdate()
    {
        score.text = Mathf.RoundToInt(bestScore*-1) + " " + "m".ToString(); //Выводим на экран лучший результат

        car1.transform.Translate( new Vector3(0f, speed, 0f));
        car2.transform.Translate(new Vector3(0f, speed, 0f));
        car3.transform.Translate(new Vector3(0f, speed, 0f));
        car4.transform.Translate(new Vector3(0f, speed, 0f));


        if (car1.transform.position.x>11f)
        {
            car1.transform.position = new Vector3(-11f, car1.transform.position.y, car1.transform.position.z);
        }
              
        if (car2.transform.position.x>11f)
        {
            car2.transform.position = new Vector3(-11f, car2.transform.position.y, car2.transform.position.z);
        }
                
        if (car3.transform.position.x<-11f)
        {
            car3.transform.position = new Vector3(11f, car3.transform.position.y, car3.transform.position.z);
        }
                
        if (car4.transform.position.x<-11f)
        {
            car4.transform.position = new Vector3(11f, car4.transform.position.y, car4.transform.position.z);
        }

        AudioListener.volume = volume.value; // громкость того, что мы слышим = громкости настроек
    }
 
}
