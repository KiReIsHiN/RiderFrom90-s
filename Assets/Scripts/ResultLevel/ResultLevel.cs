using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GameParametr;

public class ResultLevel : MonoBehaviour
{
    public Button Restart;
    public Button Exit;

    public Text bestScore;
    public Text curScore;

    private void Start()
    {
        Restart.onClick.AddListener(RestartGame);
        Exit.onClick.AddListener(QuitGame);

        curScore.text = (GameParametrs.curScore * -1) + " " + "m".ToString();
        bestScore.text = (PlayerPrefs.GetFloat("BestScore")*-1).ToString();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void QuitGame()
    {
        Application.Quit();
    }    

}
