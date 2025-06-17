using UnityEngine;

public class Botiquin : MonoBehaviour
{
    public float vida;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerControler>().tomarVida(vida);
            Destroy(gameObject);
        }
    }
}
