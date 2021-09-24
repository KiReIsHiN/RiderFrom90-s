using UnityEngine;
using GameParametr;
using PlayControllerLevel;
using UnityEngine.SceneManagement;

public class Calculations : PlayController
{
    public void FixedUpdate()
    {
        //������� �� ����� ������� ������
        kmWay.text = Mathf.RoundToInt(GameParametrs.curScore * -1) + " " + "m".ToString();
        //������� ����������� ����
        GameParametrs.curScore += GameParametrs.speed;

        //���� ���� ����� �������������, �� �������� ����� ���� � ��������� �� ��������� �����
        if (GameParametrs.hp == 0)
        {
            SceneManager.LoadScene(3);
        }

        //���� ������� ���� ������ ������� - ��������� ������� ���� � ������� �������
        if (GameParametrs.curScore < GameParametrs.bestScore)
        {
            PlayerPrefs.SetFloat("BestScore", GameParametrs.curScore);
        }

        //���������� ��������� �������� � ���������� ������
        sliderLives.value = GameParametrs.hp;

        //���� ���������� ���� �����:
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





