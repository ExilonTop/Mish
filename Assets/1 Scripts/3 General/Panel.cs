using System.Collections;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public string theName;

    CanvasGroup canvasGroup;
    public float timeTransition;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Interact(bool active)
    {
        if (!gameObject.activeSelf) gameObject.SetActive(active);

        StopAllCoroutines();
        StartCoroutine(TransitionPanel(canvasGroup, active));
    }

    IEnumerator TransitionPanel(CanvasGroup m_canvasG, bool active)
    {
        float initial = m_canvasG.alpha;
        float target = active ? 1 : 0; // -> if resumido "? consulta la condición"  ": de lo contrario, haz esto".

        // -> Aquí empieza la transición.
        for (float i = 0; i < timeTransition; i += Time.deltaTime)
        {
            float t = i / timeTransition;
            m_canvasG.alpha = Mathf.Lerp(initial, target, t);
            yield return null;
        }

        m_canvasG.alpha = target;

        // -> Aquí termina la transición.
        if (target == 0) gameObject.SetActive(false);

        yield break;
    }

}
