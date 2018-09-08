using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ARController : MonoBehaviour
{
    public GameObject[] distances;
    public FilterButtonManager filters;

    private void Update()
    {
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
