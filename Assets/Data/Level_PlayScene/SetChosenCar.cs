using UnityEngine;

    public class SetChosenCar : MonoBehaviour
    {
        public Sprite audi, car, black_viper, mini_truck;//наши срайты машин
        private SpriteRenderer mainSprite;//спрайт, в котором меняется картинка


        private readonly string selectedCaracter = "SelectedCharacter";


        void Awake()
        {
            mainSprite = this.GetComponent<SpriteRenderer>();//забирем компонент спрайт рендера с нужного объекта
        }

        // Start is called before the first frame update
        void Start()
        {
            int getCharacter;
            getCharacter = PlayerPrefs.GetInt(selectedCaracter);

            switch (getCharacter)
            {
                case 1:
                    mainSprite.sprite = car;
                    break;
                case 2:
                    mainSprite.sprite = black_viper;
                    break;
                case 3:
                    mainSprite.sprite = mini_truck;
                    break;
                case 4:
                    mainSprite.sprite = audi;
                    break;
                default:
                    mainSprite.sprite = audi;
                    break;
            }

        }
    }
