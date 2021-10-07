using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject[] roadPrefabs;

    private float spawnPos = 0f;//Позиция нешего спавна по оси z. С каждым появлением платформы увеличиваем
    private float roadLength = 10f;//Длинна нашей дороги

    private int startRoad = 3;//На старте создаем несколько дорог

    [SerializeField]
    private Transform _player;

    private List<GameObject> activeRoad = new List<GameObject>();//Списки для отслеживания активных дорог (чтобы уничтожать неактивные)


    private void Start()
    {
        //Создаем каждый раз новую дорогу
        for (int i = 0; i < startRoad; i++)
        {
            //первым элементом выбираем пустую дорогу
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

    //Создаем спавн дороги. На вход принимаем индекс дороги из массива
    public void RoadSpawn(int roadIndex)
    {
        GameObject nextRoad = Instantiate(roadPrefabs[roadIndex],transform.up * spawnPos, transform.rotation);
        activeRoad.Add(nextRoad);
        //Спавн позицию увеличиваем на длинну платформы
        spawnPos += roadLength;
    }

    //Удаляем дорогу со сцены и из списка
    private void DeleteRoad()
    {
        Destroy(activeRoad[0]);
        activeRoad.RemoveAt(0);
    }
}
