using UnityEngine;
using UnityEngine.UI;
using GameParametr;

namespace PlayControllerLevel
{
    public class PlayController : MonoBehaviour
    {
        //Наша дорога и точки ее изначального спавна
        public GameObject road1, road2;
        Vector3 road1Spawn, road2Spawn;

        public Text kmWay; //Переменная пройденного пути
        public Slider sliderLives;//Слайдер оображает наши жизни

        public AudioSource carEngine;
        public AudioSource musicLevel;


        private void Start()
        {
            //Создаем точку спавна 2 дорог и создаем сами дороги
            road1Spawn = new Vector3(0f, 0f, 0f);
            Instantiate(road1, road1Spawn, Quaternion.identity);
            road2Spawn = new Vector3(0f, 10f, 0f);
            Instantiate(road2, road2Spawn, Quaternion.identity);

            //Инициализируем лучший счет из плеер префс через переменную бест скор
            GameParametr.GameParametrs.bestScore = PlayerPrefs.GetFloat("BestScore");

            GameParametrs.hp = 99;
            GameParametrs.curScore = 0;
        }

    }
}

