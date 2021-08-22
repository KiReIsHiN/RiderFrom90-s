using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class controllerCar : MonoBehaviour

{
    public void TurnLeft()
    {
        if (transform.position.x > -1f)
        {
            transform.Translate(new Vector3(-0.5f, 0f, 0f));
        }
    }

    public void TurnRight()
    {
        if (transform.position.x < -0.5f)
        {
            transform.Translate(new Vector3(0.5f, 0f, 0f));
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
