using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
    public Sprite[] mapImages;

    [SerializeField]
    private FilterButtonManager filterButtonManager;
    [SerializeField]
    private Image currentMapImage;

    private void Start()
    {
    }

    private void Update()
    {
        UpdateMapImage(filterButtonManager.activeButton);
    }

    // Take the user to the AR scene
    public void OnExplorePress()
    {
        SceneManager.LoadScene("Main");
    }

    // Update map to selected filter
    void UpdateMapImage(int newImageIndex)
    {
        currentMapImage.sprite = mapImages[newImageIndex];
    }
}
