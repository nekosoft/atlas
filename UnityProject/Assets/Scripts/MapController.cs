using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
    [SerializeField]
    private FilterButtonManager filterButtonManager;
    [SerializeField]
    private Image currentMapImage;
    [SerializeField]
    private Image[] mapImages;

    private void Start()
    {
        mapImages = new Image[filterButtonManager.buttons.Length];
    }

    private void Update()
    {
        //UpdateMapImage(filterButtonManager.activeButton);
    }

    // Take the user to the AR scene
    public void OnExplorePress()
    {
        SceneManager.LoadScene("Main");
    }

    // Update map to selected filter
    void UpdateMapImage(int newImageIndex)
    {
        currentMapImage = mapImages[newImageIndex];
    }
}
