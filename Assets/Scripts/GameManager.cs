using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] Transform MainMenu;
    [SerializeField] Transform GameCanvas;

    public GameObject Enemy;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        instance = this;
    }
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
