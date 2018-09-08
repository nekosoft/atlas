using UnityEngine;
using UnityEngine.UI;

public class TravelManager : MonoBehaviour
{
    public Image travelPage;
    public Button travelButton;
    public Button backButton;

    public GameObject[] exteriorObj;

    public bool gotoStop;

    public bool overBack;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && travelPage.gameObject.activeSelf && !overBack)
        {
            travelPage.gameObject.SetActive(false);
            backButton.gameObject.SetActive(false);
            for (int i = 0; i < exteriorObj.Length; i++)
            {
                if (exteriorObj[i])
                {
                    exteriorObj[i].SetActive(false);
                }
            }
            gotoStop = true;
        }
    }

    public void OnWikiPress()
    {
        travelPage.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        for (int i = 0; i < exteriorObj.Length; i++)
        {
            if (exteriorObj[i])
            {
                exteriorObj[i].SetActive(false);
            }
        }
    }

    public void OnBackPress()
    {
        travelPage.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        for (int i = 0; i < exteriorObj.Length; i++)
        {
            if (exteriorObj[i])
            {
                exteriorObj[i].SetActive(true);
            }
        }
    }

    public void OnOverBack()
    {
        overBack = true;
    }

    public void OnExitBack()
    {
        overBack = false;
    }
}
