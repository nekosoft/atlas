using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ARController : MonoBehaviour
{
    public GameObject world;
    public Image wikiPage;

    bool wikiOn;

    private void Start()
    {
        wikiPage.gameObject.SetActive(false);
    }

    public void OnBackPress()
    {
        if (wikiOn)
        {
            wikiPage.gameObject.SetActive(false);
            world.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Map");
        }
    }

    public void OnWikiPress()
    {
        wikiPage.gameObject.SetActive(true);
        world.SetActive(false);
        wikiOn = true;
    }
}
