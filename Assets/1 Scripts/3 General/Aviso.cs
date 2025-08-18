using UnityEngine;
public class Aviso : MonoBehaviour
{
    public string sceneToload;
    public void Click()
    {
        SceneControler.Instance.CargarEscena(sceneToload);
    }
    public void Click2()
    {
        SceneControler.Instance.ExitGame();
    }
}
