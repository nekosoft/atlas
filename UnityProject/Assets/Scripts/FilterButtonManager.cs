using UnityEngine;
using UnityEngine.UI;

public class FilterButtonManager : MonoBehaviour
{
    public float animSpeed = 100f;
    public float swipeDistance = 207.75f;
    public Button[] buttons;
    public Image[] arrows;

    [HideInInspector]
    public int buttonPressed;

    [HideInInspector]
    public int activeButton = 0;

    private Swipe swipe;

    private Vector3 desiredPosition;

    private bool moving;

    private void Awake()
    {
        swipe = GetComponent<Swipe>();
        desiredPosition = transform.position;
        InitButtons();
        arrows[1].gameObject.SetActive(false);
    }

    private void Update()
    {
        if (swipe.SwipeDown)
        {
            Debugger.d_Message("down pressed");
            OnSwipeDown();
        }

        if (swipe.SwipeUp)
        {
            Debugger.d_Message("up pressed");
            OnSwipeUp();
        }

        //transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * animSpeed);
        if (transform.position == desiredPosition)
        {
            moving = false;
        }
    }

    void InitButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (activeButton != i)
            {
                buttons[i].gameObject.SetActive(false);
            }
        }
    }

    void OnSwipeDown()
    {
        if (activeButton != buttons.Length - 1)
        {

            //desiredPosition = new Vector3(transform.position.x, transform.position.y - SWIPE_DISTANCE, transform.position.z);
            transform.position -= new Vector3(0, swipeDistance, 0);
            moving = true;
            buttons[activeButton].gameObject.SetActive(false);
            activeButton += 1;
            buttons[activeButton].gameObject.SetActive(true);
            arrows[0].gameObject.SetActive(true);
            arrows[1].gameObject.SetActive(true);
            if (activeButton == buttons.Length - 1)
            {
                arrows[0].gameObject.SetActive(false);
            }
        }
    }

    void OnSwipeUp()
    {
        if (activeButton != 0)
        {
            //desiredPosition = new Vector3(transform.position.x, transform.position.y + SWIPE_DISTANCE, transform.position.z);
            transform.position += new Vector3(0, swipeDistance, 0);
            moving = true;
            buttons[activeButton].gameObject.SetActive(false);
            activeButton -= 1;
            buttons[activeButton].gameObject.SetActive(true);
            arrows[0].gameObject.SetActive(true);
            arrows[1].gameObject.SetActive(true);
            if (activeButton == 0)
            {
                arrows[1].gameObject.SetActive(false);
            }
        }
    }

    public void OnFilterButtonPress(int num)
    {
        buttonPressed = num;

        Debugger.d_Message(num.ToString());

        string name = "";
        switch (buttonPressed)
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