using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[Serializable]
public class WeaponData
{
    public string nombre;
    public bool isLeft; // Es el que verifica en que brazo va
    public float delay; //Cadencia de tiro
    public int bulletIndex; //Posicion de la bala
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
                obj.delayIzq = data.delay;
                foreach (BrazoRef brazo in brazosIzq)
                {
                    brazo.obj.SetActive(false);
                }
                BrazoRef brazoMatch = brazosIzq.FirstOrDefault<BrazoRef>(arm => arm.nombre == tag);
                brazoMatch.obj.SetActive(true);
                obj.currentWeaponIzq = data;
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
                obj.currentWeaponDer = data;
            }
        }   
        
    }
}
