using UnityEngine;
using UnityEngine.UI;

public class LiveScore : MonoBehaviour
{
    public Text pointDisplay;
    public Text liveDisplay;
    public Text nameDisplay;


    private void Update()
    {
        pointDisplay.text = SaveData.score.ToString();

        liveDisplay.text = SaveData.live.ToString();

        nameDisplay.text = SaveData.nameString;

    }

    public void increasePoint()
    {
        SaveData.score += 1;
    }

    public void decreasePoint()
    {
        SaveData.score -= 1;
    }

    public void increaseLive()
    {
        SaveData.live += 1;
    }

    public void decreaseLive()
    {
        SaveData.live -= 1;
    }
}
