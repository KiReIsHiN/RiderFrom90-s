using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public Button turnLeft;
    public Button turnRight;

    private void Start()
    {
        //Привязываем перемещение машины влево и вправо по нажатию клавиш
        Button btn_turnLeft = turnLeft.GetComponent<Button>();
        Button btn_turnRight = turnRight.GetComponent<Button>();
        btn_turnLeft.onClick.AddListener(TurnLeft);
        btn_turnRight.onClick.AddListener(TurnRight);
    }

    public void TurnLeft()
    {
        if (transform.position.x > -1.78f)
        {
            transform.Translate(new Vector3(-1.16f, 0f, 0f));
        }
    }

    public void TurnRight()
    {
        if (transform.position.x < 2.22f)
        {
            transform.Translate(new Vector3(1.16f, 0f, 0f));
        }
    }
}
