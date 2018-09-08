using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapButtonManager : MonoBehaviour
{

    [SerializeField]
    private Image currentMapImage;
    [SerializeField]
    private Image[] mapImages;

    // Take the user to the AR scene
    public void OnExplorePress()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnAllPress()
    {
        UpdateMapImage(mapImages[0]);
    }

    public void OnParkPress()
    {
        UpdateMapImage(mapImages[1]);
    }

    public void OnWifiPress()
    {
        UpdateMapImage(mapImages[2]);
    }

    public void OnATOPress()
    {
        UpdateMapImage(mapImages[3]);
    }

    void UpdateMapImage(Image newMapImage)
    {
        currentMapImage = newMapImage;
    }
}