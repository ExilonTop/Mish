using UnityEngine;
using UnityEngine.SceneManagement;

public class Aviso : MonoBehaviour
{
    public int sceneToload;

    public void Click()
    {
        SceneControler.Instance.CargarEscena(sceneToload);
    }
    public void Click2()
    {
        SceneControler.Instance.ExitGame();
    }
}
