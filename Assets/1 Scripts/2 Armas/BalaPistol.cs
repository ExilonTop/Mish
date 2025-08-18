using UnityEngine;
public class BalaPistol : Bala
{
    public override void Shoot()
    {
        //base.Shoot();
        //Cambia las condiciones de Shoot
        Debug.Log("Soy una bala Pistola");
    }
}
