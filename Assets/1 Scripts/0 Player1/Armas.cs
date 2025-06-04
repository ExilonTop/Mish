using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class WeaponData
{

    public string nombre;
    public WeaponType type;
    public bool isLeft;
    public float delay;
}

[Serializable]
public class BrazoRef
{
    public string nombre;
    public GameObject obj;
}



public class Armas : MonoBehaviour
{

    Disparar obj;

    public List<WeaponData> armasData = new List<WeaponData>();
    
    public List<BrazoRef> brazosIzq = new List<BrazoRef>();
    public List<BrazoRef> brazosDer = new List<BrazoRef>();

    //public GameObject izqLaser;
    //public GameObject izqEscopeta;
    //public GameObject derCañon;
    //public GameObject derFranco;


    public void Start()
    {
        obj = transform.GetComponent<Disparar>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.tag;
        WeaponData data = armasData.FirstOrDefault<WeaponData>(weapon => weapon.nombre == tag);
        if (data != null)
        {
            if (data.isLeft)
            {
                obj.delayIzq= data.delay;
                foreach (BrazoRef brazo in brazosIzq)
                {
                    brazo.obj.SetActive(false);
                }
                BrazoRef brazoMatch = brazosIzq.FirstOrDefault<BrazoRef>(arm => arm.nombre == tag);
                brazoMatch.obj.SetActive(true);
                obj.currentWeaponIzq = data.type;
            }
            else
            {
                obj.delayDer = data.delay;
                foreach (BrazoRef brazo in brazosDer)
                {
                    brazo.obj.SetActive(false);
                }
                BrazoRef brazoMatch = brazosDer.FirstOrDefault<BrazoRef>(arm => arm.nombre == tag);
                brazoMatch.obj.SetActive(true);
                obj.currentWeaponDer= data.type;
            }
        }
        
        


        /*if (collision.CompareTag("escopeta"))
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
        }*/
    }
}
