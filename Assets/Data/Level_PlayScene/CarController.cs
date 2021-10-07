using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public Button turnLeft;
    public Button turnRight;

    float carMove;

    private void Start()
    {
        InitiaizeOnStart();
    }

    private void InitiaizeOnStart()
    {
        //Привязываем перемещение машины влево и вправо по нажатию клавиш
        turnLeft.onClick.AddListener(TurnLeft);
        turnRight.onClick.AddListener(TurnRight);

        carMove = gameObject.transform.position.x;
    }


    public void TurnLeft()
    {
        if (carMove > -1.3f)//до тех пор, пока позиция больше заданной
        {
            transform.Translate(new Vector3(-0.7f, 0f, 0f));//двигаем влево
        }
    }

    public void TurnRight()
    {
        if (carMove < 1.5f)//до тех пор, пока позиция меньше заданной
        {
            transform.Translate(new Vector3(0.7f, 0f, 0f));//назначаем ей движение вправо
        }
    }


}
