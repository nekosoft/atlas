﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARButtonManager : MonoBehaviour
{
    public void OnBackPress()
    {
        SceneManager.LoadScene("Map");
    }
}
