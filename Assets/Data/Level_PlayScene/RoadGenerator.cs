using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject[] roadPrefabs;

    private float spawnPos = 0f;//������� ������ ������ �� ��� z. � ������ ���������� ��������� �����������
    private float roadLength = 10f;//������ ����� ������

    private int startRoad = 3;//�� ������ ������� ��������� �����

    [SerializeField]
    private Transform _player;

    private List<GameObject> activeRoad = new List<GameObject>();//������ ��� ������������ �������� ����� (����� ���������� ����������)


    private void Start()
    {
        //������� ������ ��� ����� ������
        for (int i = 0; i < startRoad; i++)
        {
            //������ ��������� �������� ������ ������
            if (i == 0)
                RoadSpawn(6);
            RoadSpawn(Random.Range(0,5));
        }
    }


    private void Update()
    {
        if (_player.position.y -10 > spawnPos - (startRoad * roadLength))
        {
            RoadSpawn(Random.Range(0, 5));
            DeleteRoad();
        }            
    }

    //������� ����� ������. �� ���� ��������� ������ ������ �� �������
    public void RoadSpawn(int roadIndex)
    {
        GameObject nextRoad = Instantiate(roadPrefabs[roadIndex],transform.up * spawnPos, transform.rotation);
        activeRoad.Add(nextRoad);
        //����� ������� ����������� �� ������ ���������
        spawnPos += roadLength;
    }

    //������� ������ �� ����� � �� ������
    private void DeleteRoad()
    {
        Destroy(activeRoad[0]);
        activeRoad.RemoveAt(0);
    }
}
