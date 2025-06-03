using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour
{

    Disparar obj;
    public GameObject izqLaser;
    public GameObject izqEscopeta;
    public GameObject derCañon;
    public GameObject derFranco;


    public void Start()
    {
        obj = transform.GetComponent<Disparar>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("escopeta"))
        {
            obj.currentWeaponIzq = WeaponType.Weapon2;
            izqLaser.SetActive(false);
            izqEscopeta.SetActive(true);
        }

        if (collision.CompareTag("laser"))
        {
            obj.currentWeaponIzq = WeaponType.Weapon1;
            izqEscopeta.SetActive(false);
            izqLaser.SetActive(true);
        }

        if (collision.CompareTag("cañon"))
        {
            obj.currentWeaponDer = WeaponType.Weapon1;
            derFranco.SetActive(false);
            derCañon.SetActive(true);
        }

        if (collision.CompareTag("franco"))
        {
            obj.currentWeaponDer = WeaponType.Weapon2;
            derFranco.SetActive(true);
            derCañon.SetActive(false);
        }
    }
}
