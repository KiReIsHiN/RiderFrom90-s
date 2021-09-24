using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorScript : MonoBehaviour
{

    //Переменные машин
    public GameObject audi;
    public GameObject car;
    public GameObject black_viper;
    public GameObject mini_truck;

    private SpriteRenderer audiRenderer, carRenderer, black_viperRenderer, mini_truckRenderer;
    
    //Переменные расположения машины на экране и остальных за экраном
    private Vector3 characterPosition;
    private Vector3 offScreen;

    private int characterInt = 1;//идентификатор персонажей

    private readonly string selectedCaracter = "SelectedCharacter";

    public AudioSource audioSRC;

    private void Awake()
    {
        characterPosition = audi.transform.position; //указываем, что стартовое положение машины - положение первой машины
        offScreen = car.transform.position;//а это положение за пределами экрана

        audiRenderer = audi.GetComponent<SpriteRenderer>();
        carRenderer = audi.GetComponent<SpriteRenderer>();
        black_viperRenderer = audi.GetComponent<SpriteRenderer>();
        mini_truckRenderer = audi.GetComponent<SpriteRenderer>();

        audioSRC.volume = PlayerPrefs.GetFloat("VolumeLevel");
    }

    public void NextCharacter()
    {
        switch(characterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCaracter,1);
                audiRenderer.enabled = false;
                audi.transform.position = offScreen;
                car.transform.position = characterPosition;
                carRenderer.enabled = true;
                characterInt++;
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCaracter, 2);
                carRenderer.enabled = false;
                car.transform.position = offScreen;
                black_viper.transform.position = characterPosition;
                black_viperRenderer.enabled = true;
                characterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCaracter, 3);
                black_viperRenderer.enabled = false;
                black_viper.transform.position = offScreen;
                mini_truck.transform.position = characterPosition;
                mini_truckRenderer.enabled = true;
                characterInt++;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCaracter, 4);
                mini_truckRenderer.enabled = false;
                mini_truck.transform.position = offScreen;
                audi.transform.position = characterPosition;
                audiRenderer.enabled = true;
                characterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void PreviousCharacter()
    {
        switch (characterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCaracter, 3);
                audiRenderer.enabled = false;
                audi.transform.position = offScreen;
                mini_truck.transform.position = characterPosition;
                mini_truckRenderer.enabled = true;
                characterInt--;
                ResetInt();
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCaracter, 4);
                carRenderer.enabled = false;
                car.transform.position = offScreen;
                audi.transform.position = characterPosition;
                audiRenderer.enabled = true;
                characterInt--;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCaracter, 1);
                black_viperRenderer.enabled = false;
                black_viper.transform.position = offScreen;
                car.transform.position = characterPosition;
                carRenderer.enabled = true;
                characterInt--;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCaracter, 2);
                mini_truckRenderer.enabled = false;
                mini_truck.transform.position = offScreen;
                black_viper.transform.position = characterPosition;
                black_viperRenderer.enabled = true;
                characterInt--;
                break;
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if (characterInt >= 4)
        {
            characterInt = 1;
        }
        else
        {
            characterInt = 4;
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }

}
