using UnityEngine;
using UnityEngine.UI;

public class WikiManager : MonoBehaviour
{
    public Image wikiPage;
    public Button wikiButton;
    public Button backButton;

    public GameObject exteriorObj;

    public Sprite[] wikis;

    int wikiInd = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && wikiPage.gameObject.activeSelf)
        {
            if (wikiInd < wikis.Length)
            {
                wikiPage.sprite = wikis[wikiInd];
                wikiInd++;
            }
        }
    }

    public void OnWikiPress()
    {
        wikiPage.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        if (exteriorObj)
            exteriorObj.SetActive(false);
    }

    public void OnBackPress()
    {
        wikiPage.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        if (exteriorObj)
            exteriorObj.SetActive(true);
        wikiInd = 1;
    }
}
