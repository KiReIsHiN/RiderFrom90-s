using UnityEngine;
using GameParametr;

public class RoadMove : MonoBehaviour
{


    private void FixedUpdate()
    {
        transform.Translate(new Vector3(0f, GameParametrs.speed, 0f));// �������� ������ �� ��� �
        // ���� ������ ������ �� ������� ������ �� ��� "���������������" �����
        if (transform.position.y <= -10f)
        {
            transform.position = new Vector3(0f, 9f, 0f);//����� ������� ������
        }
    }

}
