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
        //����������� ����������� ������ ����� � ������ �� ������� ������
        turnLeft.onClick.AddListener(TurnLeft);
        turnRight.onClick.AddListener(TurnRight);

        carMove = gameObject.transform.position.x;
    }


    public void TurnLeft()
    {
        if (carMove > -1.3f)//�� ��� ���, ���� ������� ������ ��������
        {
            transform.Translate(new Vector3(-0.7f, 0f, 0f));//������� �����
        }
    }

    public void TurnRight()
    {
        if (carMove < 1.5f)//�� ��� ���, ���� ������� ������ ��������
        {
            transform.Translate(new Vector3(0.7f, 0f, 0f));//��������� �� �������� ������
        }
    }


}
