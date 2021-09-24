using UnityEngine;
using GameParametr;
using PlayControllerLevel;
using UnityEngine.SceneManagement;

public class Calculations : PlayController
{
    public void FixedUpdate()
    {
        //Выводим на экран текущий пробег
        kmWay.text = Mathf.RoundToInt(GameParametrs.curScore * -1) + " " + "m".ToString();
        //Подсчет пройденного пути
        GameParametrs.curScore += GameParametrs.speed;

        //Если наши жизни заканчиваются, то скорость равна нулю и переходим на следующую сцену
        if (GameParametrs.hp == 0)
        {
            SceneManager.LoadScene(3);
        }

        //Если текущий счет больше рекорда - сохраняем текущий счет в каестве рекорда
        if (GameParametrs.curScore < GameParametrs.bestScore)
        {
            PlayerPrefs.SetFloat("BestScore", GameParametrs.curScore);
        }

        //Приравняли показания слайдера к переменной жизней
        sliderLives.value = GameParametrs.hp;

        //Надо переделать этот кусок:
        if(GameParametrs.curScore == 100)
        {
            GameParametrs.speed = -0.2f;
        }
        else if (GameParametrs.curScore == 200)
        {
            GameParametrs.speed = -0.3f;
        }
        else if (GameParametrs.curScore == 300)
        {
            GameParametrs.speed = -0.4f;
        }
        else if (GameParametrs.curScore == 400)
        {
            GameParametrs.speed = -0.5f;
        }
        else if (GameParametrs.curScore == 500)
        {
            GameParametrs.speed = -0.6f;
        }
        else if (GameParametrs.curScore == 600)
        {
            GameParametrs.speed = -0.7f;
        }
        else if (GameParametrs.curScore == 700)
        {
            GameParametrs.speed = -0.8f;
        }
        else if (GameParametrs.curScore == 800)
        {
            GameParametrs.speed = -0.9f;
        }
        else if (GameParametrs.curScore == 900)
        {
            GameParametrs.speed = -1f;
        }

    }
}





