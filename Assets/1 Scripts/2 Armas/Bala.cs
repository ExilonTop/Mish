using UnityEngine;
public class Bala : MonoBehaviour
{
    public float daño;
    public float velocidad;
    public float timeLife;
    public float timeDead;
    private void Update()
    {
        Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerControler>().tomarDaño(daño);
            Destroy(gameObject);
        }
    }
    private void Move()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        timeLife += Time.deltaTime;
        if (timeLife >= timeDead)
        {
            Destroy(gameObject);
        }
    }
    public virtual void Shoot()
    {
        
    }
}
