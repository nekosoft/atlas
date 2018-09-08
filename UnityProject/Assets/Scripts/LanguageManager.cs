using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Image page;
    public Button languageButton;
    public Button backButton;

    public GameObject exteriorObj;
    
    public void OnLanguagePress()
    {
        page.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        if (exteriorObj)
            exteriorObj.SetActive(false);
    }

    public void OnBackPress()
    {
        page.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        if (exteriorObj)
            exteriorObj.SetActive(true);
    }

}
