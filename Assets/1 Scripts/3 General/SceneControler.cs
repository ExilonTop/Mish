using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{
    public static SceneControler Instance { get; private set; }

    private void Awake() 
{ 
    // If there is an instance, and it's not me, delete myself.
    
    if (Instance != null && Instance != this) 
    { 
        Destroy(this); 
    } 
    else 
    { 
        Instance = this;
        DontDestroyOnLoad(this.gameObject); 
    } 
}
    
    public void CargarEscena(string escena) 
    {
        SceneManager.LoadScene(escena);
    }

    public void ExitGame() => Application.Quit();
}
