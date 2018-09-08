using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitialScreen : MonoBehaviour
{
    public Sprite[] screens;

    private Image startPage;

    private int pageCount = 1;

    private void Start()
    {
        startPage = GetComponent<Image>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (pageCount < screens.Length)
            {
                startPage.sprite = screens[pageCount];
            }
            else
            {
                SceneManager.LoadScene("Map");
            }

            pageCount++;
        }
    }
}