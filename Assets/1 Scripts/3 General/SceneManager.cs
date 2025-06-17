using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using SceneM = UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [Header("=== NECESSARY ===")]
    public CanvasGroup m_cg;

    public static SceneManager Instance;

    public float timeBeforeTransition;
    public float timeTransition;

    private void Awake()
    {
        Instance = this;
        // m_cg.alpha = 1;
        // StartCoroutine(Transition(m_cg));

        SceneM.SceneManager.activeSceneChanged += OnSceneChanged;
    }

    void OnDisable()
    {
        SceneM.SceneManager.activeSceneChanged -= OnSceneChanged;
    }

    void OnSceneChanged(SceneM.Scene current, SceneM.Scene newScene)
    {
        Debug.Log("Cambio");

        m_cg.alpha = 1;
        StartCoroutine(Transition(m_cg));
    }

    public void ChangeScene(string name)
    {
        Debug.Log("Inicio la corrutina BUAAAJ");
        StartCoroutine(Transition(m_cg, name));
    }

    public void ExitGame() => Application.Quit();

    /// <summary>
    /// Corrutina ! :)
    /// </summary>
    IEnumerator Transition(CanvasGroup m_canvasG, string name = "")
    {
        float initial = m_canvasG.alpha;
        float target = initial == 1 ? 0 : 1;
        
        //yield return new WaitForSeconds(initial == 0 ? timeBeforeTransition : 0);

        for (float i = 0; i < timeTransition; i += Time.unscaledDeltaTime)
        {
            float t = i / timeTransition;
            m_canvasG.alpha = Mathf.Lerp(initial, target, t);
            yield return null;
        }

        m_canvasG.alpha = target;

        if (string.IsNullOrEmpty(name)) yield break;
        else LoadScene(name);
    }

    /// <summary>
    /// Esta funci�n sirve para cargar una escena desde cualquier lugar.
    /// </summary>
    void LoadScene(string nameScene)
    {
        Time.timeScale = 1;
        SceneM.SceneManager.LoadScene(nameScene);
    }

}
