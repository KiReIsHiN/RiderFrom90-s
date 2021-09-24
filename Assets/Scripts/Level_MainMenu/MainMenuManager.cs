using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GameParametr;
namespace MainMenuLevel
{

    public class MainMenuManager : MonoBehaviour
    {




        //��������� ������
        public Button play;
        public Button exit;
        public Button settings;
        public Button backToMainMenu;

        //���������� �����, ������� � ������ ��������
        public Text BestScoreCount;
        public GameObject PanelSettings;
        public Slider soundLevelSlider;

        //������� ���������� ��� ������ ��������� ������ � ����
        public float soundLevel;
        public AudioSource audioSource;

        public GameObject car;
        public float speed;


        private void Start()
        {
            //�������� �������� �� ������� ������
            play.onClick.AddListener(LoadNextLevel);
            settings.onClick.AddListener(ShowPanelSettings);
            exit.onClick.AddListener(Quit);
            backToMainMenu.onClick.AddListener(BackToMainMenu);

            if (soundLevelSlider != null)
            {
                soundLevelSlider.normalizedValue = PlayerPrefs.HasKey("VolumeLevel") ? PlayerPrefs.GetFloat("VolumeLevel") : soundLevel;
            }

            //������� �� ����� ������ ���������
            BestScoreCount.text = (PlayerPrefs.GetFloat("BestScore")*-1) + " " + "m".ToString();
        }

        public void FixedUpdate()
        {
            
            //�������, ��� ��� ��������� �������� �������� �������� � ������� ��������� ��������� �����
            audioSource.volume = soundLevelSlider.value;


            car.transform.Translate(new Vector3(0f, speed, 0f));// �������� ������ �� ��� �

            if (car.transform.position.y > 5f)
            {
                car.transform.position = new Vector3(0f, -5f, 0f);//����� ������� ������
            }

        }







        //���������� ������� ������
        public void ShowPanelSettings() => PanelSettings.SetActive(true);
        public void LoadNextLevel() => SceneManager.LoadScene(1);
        public void Quit() => Application.Quit();
        public void BackToMainMenu()
        {
            PanelSettings.SetActive(false);
            //��� �������� ������ �������� ��������� ���������� ������ � ���������� ���������
            PlayerPrefs.SetFloat("VolumeLevel", soundLevelSlider.normalizedValue);
        }



            


    }
}
