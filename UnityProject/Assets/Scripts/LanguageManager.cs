using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Image languagePage;
    public Button languageButton;
    public Button backButton;

    public GameObject exteriorObj;
    
    public void OnLanguagePress()
    {
        languagePage.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        if (exteriorObj)
            exteriorObj.SetActive(false);
    }

    public void OnBackPress()
    {
        languagePage.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        if (exteriorObj)
            exteriorObj.SetActive(true);
    }

}
