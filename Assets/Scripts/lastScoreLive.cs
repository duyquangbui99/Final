using UnityEngine.UI;
using UnityEngine;

public class lastScoreLive : MonoBehaviour
{
    public Text lastScore;
    public Text lastLive;

    // Update is called once per frame
    void Update()
    {
        lastScore.text = "SCORE: " + SaveData.score;
        lastLive.text = "LIVE: " + SaveData.live;
    }
}
