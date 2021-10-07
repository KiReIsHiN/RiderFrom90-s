using GameParametr;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PlayControllerLevel
{
    public class PlayController : MonoBehaviour
    {
        [Tooltip("Переменная пройденного пути")]
        public Text kmWay;

        [Tooltip("Переменная собранных монет")]
        public Text coins;

        [Tooltip("Слайдер оображает наши жизни")]
        public Slider sliderLives;

        [Tooltip("Слайдер оображает собранные монеты")]
        public Slider sliderCoins;

        [Tooltip("Наш щит")]
        public GameObject schield;

        [Tooltip("Камера")]
        public GameObject mainCamera;

        [Tooltip("звук мотора")]
        public AudioSource carEngine;

        [Tooltip("музыка уровня")]
        public AudioSource musicLevel;

        [Tooltip("Трансформ нашего игрока")]
        public GameObject playerTransform;







        public void Start()
        {
            //установили громкость музыки
            carEngine.volume = PlayerPrefs.GetFloat("VolumeLevel");
            musicLevel.volume = PlayerPrefs.GetFloat("VolumeLevel");
            //определили лучший счет
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
            //если проигрываем
            if (GameParametrs.hp == 0)
            {
                //Сравниваем пройденный путь и лучший путь и записываем
                if (GameParametrs.curScore > GameParametrs.bestScore)
                {
                    PlayerPrefs.SetFloat("BestScore", GameParametrs.curScore);
                    //Говорим, что это новый рекорд
                    GameParametrs.record = true;
                }
                else
                {
                    GameParametrs.record = false;
                }

                //Загружаем следующую сцену
                SceneManager.LoadScene(3);
                //И выставляем жизни снова на 99
                GameParametrs.hp = 99;
            }
        }

        public void PlayWindowCalc()
        {
            // подсчитываем пройденный путь путем отслеживания положения игрока по оси у
            GameParametrs.curScore = playerTransform.transform.position.y;
            //выводим на экран пройденный путь в км
            kmWay.text = ((int)GameParametrs.curScore / 2) + " " + "km".ToString();
            //привязываем значение слайдера к жизням
            sliderLives.value = GameParametrs.hp;
            //привязываем значение слайдера к собранным монетам
            sliderCoins.value = GameParametrs.coinsToProtects;
            coins.text = GameParametrs.coins.ToString();
        }

        public void EnableSchield()
        {
            //Если собрано 10 монеток, то включаем щит и обнуляем показания слайдера монеток
            if (GameParametrs.coinsToProtects == 10)
            {
                GameParametrs.coinsToProtects = 0;
                GameParametrs.hasProtect = true;
            }

            //Отображаем включенный щит
            if (GameParametrs.hasProtect == true)
            {
                schield.SetActive(true);
            }
            else
            { schield.SetActive(false); }
        }






    }
}

