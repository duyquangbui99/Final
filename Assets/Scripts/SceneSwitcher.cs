using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void loadGame()
    {
        SceneManager.LoadScene("2Game");
    }

    public void loadExit()
    {
        SceneManager.LoadScene("3Exit");
    }

    public void restartGame()
    {
        SceneManager.LoadScene("2Game");
        SaveData.score = 0;
        SaveData.live = 3;
    }

    public void closeGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
