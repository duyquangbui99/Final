using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public Dropdown liveDropdown;
    public Slider timeSlider;
    public InputField nameInputfield;


    //public Text welcome;
    public Text second;


    public static int score = 0;
    public static int live = 1;
    public static string nameString;


    public void nameUpdate()
    {
        nameString = nameInputfield.text;
        //welcome.text = nameString;
    }

    public void liveUpdate()
    {
        switch (liveDropdown.value)
        {
            default:
                live = 1;
                break;
            case 0:
                live = 1;
                break;
            case 1:
                live = 3;
                break;
            case 2:
                live = 9;
                break;
        }
    }

    public void timeUpdate(float value)
    {
        TimerCountdown.sendcondLeft = timeSlider.value;
        second.text = timeSlider.value.ToString("0");
    }


}
