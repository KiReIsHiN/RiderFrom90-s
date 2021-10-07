using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GameParametr;
namespace MainMenuLevel
{

    public class MainMenuManager : MonoBehaviour
    {




        //объявляем кнопки
        public Button play;
        public Button exit;
        public Button settings;
        public Button backToMainMenu;

        //определяем текст, слайдер и панель настроек
        public Text BestScoreCount;
        public GameObject PanelSettings;
        public Slider soundLevelSlider;

        //создаем переменную для уровня громкости звуков в игре
        public float soundLevel;
        public AudioSource audioSource;

        public GameObject car;


        private void Start()
        {
            //Добавили действия по нажатию кнопок
            play.onClick.AddListener(LoadNextLevel);
            settings.onClick.AddListener(ShowPanelSettings);
            exit.onClick.AddListener(Quit);
            backToMainMenu.onClick.AddListener(BackToMainMenu);

            if (soundLevelSlider != null)
            {
                soundLevelSlider.normalizedValue = PlayerPrefs.HasKey("VolumeLevel") ? PlayerPrefs.GetFloat("VolumeLevel") : soundLevel;
            }

            //Выводим на экран лучший результат
            BestScoreCount.text = (int)GameParametrs.bestScore + " " + "km".ToString();
        }

        public void FixedUpdate()
        {
            
            //Говорим, что при изменении значения слайдера меняется и зачение громкости источника звука
            audioSource.volume = soundLevelSlider.value;


            car.transform.Translate(new Vector3(0f, GameParametrs.speed, 0f));// Движение машины по оси у

            if (car.transform.position.y > 5f)
            {
                car.transform.position = new Vector3(0f, -5f, 0f);//новая позиция дороги
            }

        }







        //определили функции кнопок
        public void ShowPanelSettings() => PanelSettings.SetActive(true);
        public void LoadNextLevel() => SceneManager.LoadScene(1);
        public void Quit() => Application.Quit();
        public void BackToMainMenu()
        {
            PanelSettings.SetActive(false);
            //при закрытии панели настроек сохраняем измененные данные в глобальные настройки
            PlayerPrefs.SetFloat("VolumeLevel", soundLevelSlider.normalizedValue);
        }



            


    }
}
