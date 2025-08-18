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
        canvasPausa.SetActive(false);
        canvasVic1.SetActive(false);
        canvasVic2.SetActive(false);
        if (gano != true) { canvasGameplay.SetActive(true); }
        inPausa = false;
        Time.timeScale = 1;
    }
    public void quienGano()
    {
        Time.timeScale = 0;
        inPausa = true;
        gano = true;
        canvasGameplay.SetActive(false);
        canvasVic1.SetActive(true);
    }
    public void quienGano2()
    {
        Time.timeScale = 0;
        inPausa = true;
        gano = true;
        canvasGameplay.SetActive(false);
        canvasVic2.SetActive(true);
    }
}
