using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject canvasPausa;
    public GameObject canvasGameplay;
    public GameObject canvasVic1;
    public GameObject canvasVic2;
    public bool inPausa = false;
    public bool gano = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (inPausa != true)
            {
                canvasGameplay.SetActive(false);
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
        canvasVic1.SetActive(false);
        canvasVic2.SetActive(false);
        if(gano!=true){canvasGameplay.SetActive(true);}
        inPausa = false;
    }
    public void quienGano()
    {
        inPausa = true;
        gano = true;
        canvasGameplay.SetActive(false);
        canvasVic1.SetActive(true);
        Time.timeScale = 0;
    }
    public void quienGano2()
    {
        inPausa = true;
        gano = true;
        canvasGameplay.SetActive(false);
        canvasVic2.SetActive(true);
        Time.timeScale = 0;
    }
}
