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
    public Text collectedCoins;
    public Text congratulation;

    private void Start()
    {
        Restart.onClick.AddListener(RestartGame);
        Exit.onClick.AddListener(QuitGame);

        curScore.text = (int)GameParametrs.curScore + " " + "km".ToString();
        bestScore.text = (int)GameParametrs.bestScore + " " + "km".ToString();
        collectedCoins.text = GameParametrs.coins.ToString();

        if (GameParametrs.record == true)
        {
            congratulation.gameObject.SetActive(true);
        }
        else
        {
            congratulation.gameObject.SetActive(false);
        }
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
