using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;

    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Continue();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void Continue()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    void PauseGame()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }


    public void saveGame()
    {
        PlayerPrefs.SetInt("score", SaveData.score);
        PlayerPrefs.SetInt("live", SaveData.live);
        PlayerPrefs.SetString("name", SaveData.nameString);

        Debug.Log("Saved Game");
    }

    public void loadGame()
    {
        SaveData.score = PlayerPrefs.GetInt("score");
        SaveData.live = PlayerPrefs.GetInt("live");
        SaveData.nameString = PlayerPrefs.GetString("name");
        Continue();

        Debug.Log("Loaded Game");
    }

    public void NewGame()
    {
        SaveData.score = 0;
        SaveData.live = 3;
        SceneManager.LoadScene("2Game");
        Continue();
    }

    public void MusicToggle()
    {
        if (MusicScript.BgInstance.Audio.isPlaying)
        {
            MusicScript.BgInstance.Audio.Pause();
        }
        else
        {
            MusicScript.BgInstance.Audio.Play();
        }
    }

    public void SaveAsJson()
    {
        JsonData data = new JsonData();

        data.Name = SaveData.nameString;
        data.Score = SaveData.score.ToString();
        data.Live = SaveData.live.ToString();

        string json = JsonUtility.ToJson(data);

        Debug.Log("Save as JSON:" + json);

    }

}
