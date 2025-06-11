using UnityEngine;
public class Bala : MonoBehaviour
{
    public float daño;
    public float velocidad;
    public float timeLife;   
    private void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerControler>().tomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
