using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform MainMenu;
    [SerializeField] Transform GameCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        MainMenu.gameObject.SetActive(false);
        GameCanvas.gameObject.SetActive(true);
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
