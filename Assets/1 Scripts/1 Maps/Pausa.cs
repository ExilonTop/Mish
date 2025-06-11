using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject canvasPausa;
    public bool inPausa = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (inPausa != true)
            {
                canvasPausa.SetActive(true);
                Time.timeScale = 0;
                inPausa = true;
            }
        }
    }

    public void unPausa()
    {
        Time.timeScale = 1;
        canvasPausa.SetActive(false);
        inPausa = false;
    } 
}
