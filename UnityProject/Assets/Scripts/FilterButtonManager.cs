using UnityEngine;
using UnityEngine.UI;

public class FilterButtonManager : MonoBehaviour
{
    public Button[] buttons;

    [HideInInspector]
    public int buttonPressed;

    int activeButton = 0;

    const float SWIPE_DISTANCE = 187.5f;

    private void Awake()
    {
        InitButtons();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            OnSwipeDown();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            OnSwipeUp();
        }
    }

    void InitButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (activeButton != i)
            {
                buttons[i].enabled = false;
            }
        }
    }

    void OnSwipeDown()
    {
        if (activeButton != 0)
        {
            transform.position += new Vector3(0, SWIPE_DISTANCE, 0);
            buttons[activeButton].enabled = false;
            activeButton -= 1;
            buttons[activeButton].enabled = true;
        }
        else
        {
            Debugger.d_Message("end");
        }
    }

    void OnSwipeUp()
    {
        if (activeButton != buttons.Length)
        {
            transform.position -= new Vector3(0, SWIPE_DISTANCE, 0);
            buttons[activeButton].enabled = false;
            activeButton += 1;
            buttons[activeButton].enabled = true;
        }
        else
        {
            Debugger.d_Message("start");
        }
    }

    public void OnFilterButtonPress(int num)
    {
        buttonPressed = num;

        string name = "";
        switch (num)
        {
            case 0:
                name = "All";
                break;
            case 1:
                name = "Wifi";
                break;
            case 2:
                name = "Transport";
                break;
            case 3:
                name = "Parks";
                break;
            case 4:
                name = "ATO";
                break;
            default:
                Debugger.d_Error("Filer name defaulted");
                break;
        }

        Debugger.d_ButtonPressed("Filter - " + name);
    }
}