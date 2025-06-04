using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum WeaponType
{
    None,
    Weapon1,
    Weapon2
}

public class Disparar : MonoBehaviour
{
    public float player;
    public bool canDispararIzq = true;
    public bool canDispararDer = true;
    public float delayIzq = 0;
    private float timerizq = 0f;
    public float delayDer = 0;
    private float timerDer = 0f;

    [Header("ArmasIzq")]
    public WeaponType currentWeaponIzq;
    public Transform armaizq;
    public List<GameObject> armasIzq = new List<GameObject>();

    [Header("ArmaDer")]
    public WeaponType currentWeaponDer;
    public Transform armader;
    public List<GameObject> armasDer = new List<GameObject>();

    private void Update()
    {
        if (canDispararIzq)
        {
            atacarIzq();
        }
        else
        {
            if (timerizq >= delayIzq)
            {
                //Hacemos algo
                canDispararIzq = true;
                timerizq = 0f;
            }
            else
            {
                //echa a andar el reloj
                timerizq += Time.deltaTime;
            }
        }
        if (canDispararDer)
        {
            atacarDer();
        }
        else
        {
            if (timerDer >= delayDer)
            {
                //Hacemos algo
                canDispararDer = true;
                timerDer = 0f;
            }
            else
            {
                //echa a andar el reloj
                timerDer += Time.deltaTime;
            }
        }
    }
    private void atacarIzq()
    {
        if (player == 1 && Input.GetButtonDown("FireQ"))
        {
            //DispararIzq();
            DispararGeneric(currentWeaponIzq, armasIzq, armaizq);
        }


        if (player == 2 && Input.GetButtonDown("Fire1"))
        {
            //DispararIzq();
            DispararGeneric(currentWeaponIzq, armasIzq, armaizq);
        }
        canDispararIzq = true;
        
    }

    private void atacarDer()
    {
        if (player == 1 && Input.GetButtonDown("FireE"))
        {
            //DispararDer();
            DispararGeneric(currentWeaponDer, armasDer, armader);
        }
        if (player == 2 && Input.GetButtonDown("Fire2"))
        {
            //DispararDer();
            DispararGeneric(currentWeaponDer, armasDer, armader);
        }
        canDispararDer = true;
    }
    /*public void DispararIzq()
    {
        switch (currentWeaponIzq)
        {
            case WeaponType.None:
                break;
            case WeaponType.Weapon1:
                Instantiate(armasIzq[0], armaizq.position, armaizq.rotation);
                break;
            case WeaponType.Weapon2:
                Instantiate(armasIzq[1], armaizq.position, armaizq.rotation);
                break;
        }
    }
    public void DispararDer()
    {
        switch (currentWeaponDer) //
        {
            case WeaponType.None:
                break;
            case WeaponType.Weapon1:
                Instantiate(armasDer[0], armader.position, armader.rotation);
                break;
            case WeaponType.Weapon2:
                Instantiate(armasDer[1], armader.position, armader.rotation);
                break;
        }
    }*/


    public void DispararGeneric(WeaponType brazo, List<GameObject> balas, Transform spawnPoint)
    {
        switch (brazo)
        {
            case WeaponType.None:
                break;
            case WeaponType.Weapon1:
                Instantiate(balas[0], spawnPoint.position, spawnPoint.rotation);
                break;
            case WeaponType.Weapon2:
                Instantiate(balas[1], spawnPoint.position, spawnPoint.rotation);
                break;
        }
    }

}
