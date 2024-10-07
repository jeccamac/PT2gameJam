using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else { Destroy(this.gameObject); }
    }

    public void QuitToDesktop()
    {
        Application.Quit();
        Debug.Log("quit to desktop");
    }
}
