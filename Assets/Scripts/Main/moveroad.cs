using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class moveroad : MonoBehaviour
{
    public float curScore = 0, bestScore;// переменные для хранения расстояния и рекорда
    public float speed = -0.03f;
    public Text kmWay; //Пересенная пройденного пути
    public Text record; //Пересенная лучшего счета
    public GameObject road; //Наша дорога

    public GameObject enemy;
    private Enemies enemies;

    public GameObject myCar; //Наша машина

    void Start()
    {
        bestScore = PlayerPrefs.GetFloat("bestScore", bestScore); //Извлекаем переменну лучшего счета из глобальных данных
        myCar.transform.position = new Vector3(-1f, myCar.transform.position.y, myCar.transform.position.z);//Респавн нашего автомобиля
    }


    void FixedUpdate()
    {
        road.transform.Translate ( new Vector3(0f, speed, 0f));// Движение дороги по оси у
        // если дорога уходит за пределы камеры то она "телепортируется" вверх
        if (road.transform.position.y < -11f)
        {
            road.transform.position = new Vector3(0f, 11f, 0f);//новая позиция дороги
        }
        curScore = curScore + speed; //Подсчет пройденного пути

        //Выводим на экран текущий километраж и лучший результат
        kmWay.text = Mathf.RoundToInt(curScore*-1) + " " + "m".ToString();
        record.text = Mathf.RoundToInt(bestScore*-1) + " " + "m".ToString();

        //Если мы проехали путь больше рекодра, то записываем новый рекорд
        if (bestScore>curScore)
        {
            PlayerPrefs.SetFloat("bestScore", bestScore); 
        }
       

        
        if (curScore < -50.0f)
        {
            speed=-0.06f;
        }

        if (curScore < -150.0f)
        {
            speed = -0.08f;
        }
        
    }

}