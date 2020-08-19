using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject player;
    public GameObject menuCamera;
    public GameObject menuPanel;

    public void Start()
    {

        player.SetActive(false);
    }
    public void StartGame()
    {
        menuCamera.SetActive(false);
        menuPanel.SetActive(false);
        menuPanel.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
