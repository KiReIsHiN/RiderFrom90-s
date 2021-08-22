using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainCharacter : MonoBehaviour
{
    public Sprite audi, car, black_viper, mini_truck;
    private SpriteRenderer mySprite;

    private readonly string selectedCaracter = "SelectedCharacter";

    void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        int getCharacter;
        getCharacter = PlayerPrefs.GetInt(selectedCaracter);

        switch (getCharacter)
        {
            case 1:
                mySprite.sprite = car;
                break;
            case 2:
                mySprite.sprite = black_viper;
                break;
            case 3:
                mySprite.sprite = mini_truck;
                break;
            case 4:
                mySprite.sprite = audi;
                break;
            default:
                mySprite.sprite = audi;
                break;
        }
    }

}
