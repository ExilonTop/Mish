using UnityEngine;
public class Botiquin : MonoBehaviour
{
    public float vida;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerControler jugador = collision.GetComponent<PlayerControler>();
        if (jugador!=null)
        {
            if (jugador.hp < jugador.hpMax)
            {
                jugador.tomarVida(vida);
                Destroy(gameObject);
            }
        }
    }
}
