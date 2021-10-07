using GameParametr;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PlayControllerLevel
{
    public class PlayController : MonoBehaviour
    {
        [Tooltip("���������� ����������� ����")]
        public Text kmWay;

        [Tooltip("���������� ��������� �����")]
        public Text coins;

        [Tooltip("������� ��������� ���� �����")]
        public Slider sliderLives;

        [Tooltip("������� ��������� ��������� ������")]
        public Slider sliderCoins;

        [Tooltip("��� ���")]
        public GameObject schield;

        [Tooltip("������")]
        public GameObject mainCamera;

        [Tooltip("���� ������")]
        public AudioSource carEngine;

        [Tooltip("������ ������")]
        public AudioSource musicLevel;

        [Tooltip("��������� ������ ������")]
        public GameObject playerTransform;







        public void Start()
        {
            //���������� ��������� ������
            carEngine.volume = PlayerPrefs.GetFloat("VolumeLevel");
            musicLevel.volume = PlayerPrefs.GetFloat("VolumeLevel");
            //���������� ������ ����
            GameParametrs.bestScore = PlayerPrefs.GetFloat("BestScore");

            GameParametrs.coins = 0;
            GameParametrs.coinsToProtects = 0;
        }

        public void FixedUpdate()
        {
            PlayWindowCalc();
            IfDie();
            EnableSchield();
        }













        public void IfDie()
        {
            //���� �����������
            if (GameParametrs.hp == 0)
            {
                //���������� ���������� ���� � ������ ���� � ����������
                if (GameParametrs.curScore > GameParametrs.bestScore)
                {
                    PlayerPrefs.SetFloat("BestScore", GameParametrs.curScore);
                    //�������, ��� ��� ����� ������
                    GameParametrs.record = true;
                }
                else
                {
                    GameParametrs.record = false;
                }

                //��������� ��������� �����
                SceneManager.LoadScene(3);
                //� ���������� ����� ����� �� 99
                GameParametrs.hp = 99;
            }
        }

        public void PlayWindowCalc()
        {
            // ������������ ���������� ���� ����� ������������ ��������� ������ �� ��� �
            GameParametrs.curScore = playerTransform.transform.position.y;
            //������� �� ����� ���������� ���� � ��
            kmWay.text = ((int)GameParametrs.curScore / 2) + " " + "km".ToString();
            //����������� �������� �������� � ������
            sliderLives.value = GameParametrs.hp;
            //����������� �������� �������� � ��������� �������
            sliderCoins.value = GameParametrs.coinsToProtects;
            coins.text = GameParametrs.coins.ToString();
        }

        public void EnableSchield()
        {
            //���� ������� 10 �������, �� �������� ��� � �������� ��������� �������� �������
            if (GameParametrs.coinsToProtects == 10)
            {
                GameParametrs.coinsToProtects = 0;
                GameParametrs.hasProtect = true;
            }

            //���������� ���������� ���
            if (GameParametrs.hasProtect == true)
            {
                schield.SetActive(true);
            }
            else
            { schield.SetActive(false); }
        }






    }
}

