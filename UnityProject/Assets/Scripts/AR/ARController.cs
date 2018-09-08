using UnityEngine;
using UnityEngine.SceneManagement;

public class ARController : MonoBehaviour
{
    public GameObject[] distances;
    public FilterButtonManager filters;
    public WikiManager wikiManager;
    public LanguageManager languageManager;

    private void Update()
    {
        if (!wikiManager.wikiPage.IsActive() || !languageManager.languagePage)
        for (int i = 0; i < distances.Length; i++)
        {
            if (distances[i])
            {
                if (filters.activeButton == 0)
                {
                    distances[i].SetActive(true);
                    continue;
                }

                if (i == filters.activeButton)
                {
                    distances[filters.activeButton].SetActive(true);
                }
                else
                {
                    distances[i].SetActive(false);
                }
            }
        }
    }

    public void OnBackPress()
    {
        SceneManager.LoadScene("Map");
    }
}
