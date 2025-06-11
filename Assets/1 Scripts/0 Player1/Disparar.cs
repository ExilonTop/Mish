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
    public bool canDispararIzq;
    public bool canDispararDer;
    public float delayIzq = 0;
    public float timerIzq = 0f;
    public float delayDer = 0;
    public float timerDer = 0f;
    [Header("ArmasIzq")]
    public WeaponType currentWeaponIzq;
    public Transform armaizq;
    public List<Bala> armasIzq = new List<Bala>();
    [Header("ArmaDer")]
    public WeaponType currentWeaponDer;
    public Transform armader;
    public List<Bala> armasDer = new List<Bala>();
    private void Update()
    {
        if (canDispararIzq==true)
        {
            atacarIzq();
        }
        else
        {
            if (timerIzq >= delayIzq)
            {
                //Hacemos algo
                canDispararIzq = true;
                timerIzq = 0f;
            }
            else
            {
                //echa a andar el reloj
                timerIzq += Time.deltaTime;
            }
        }
        if (canDispararDer==true)
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
        if (player == 1 && Input.GetButton("FireQ"))
        {
            //DispararIzq();
            DispararGeneric(currentWeaponIzq, armasIzq, armaizq);
            canDispararIzq = false;
        }
        if (player == 2 && Input.GetButton("Fire1"))
        {
            //DispararIzq();
            DispararGeneric(currentWeaponIzq, armasIzq, armaizq);
            canDispararIzq = false;

        }
        
    }
    private void atacarDer()
    {
        if (player == 1 && Input.GetButton("FireE"))
        {
            //DispararDer();
            DispararGeneric(currentWeaponDer, armasDer, armader);
            canDispararDer = false;

        }
        if (player == 2 && Input.GetButton("Fire2"))
        {
            //DispararDer();
            DispararGeneric(currentWeaponDer, armasDer, armader);
            canDispararDer = false;

        }
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
    public void DispararGeneric(WeaponType brazo, List<Bala> balas, Transform spawnPoint)
    {
        switch (brazo)
        {
            case WeaponType.None:
                break;
            case WeaponType.Weapon1:
                Bala bala = Instantiate(balas[0], spawnPoint.position, spawnPoint.rotation);
                bala.Shoot();
                break;
            case WeaponType.Weapon2:
                Bala bala2 = Instantiate(balas[1], spawnPoint.position, spawnPoint.rotation);
                bala2.Shoot();
                break;
        }
    }
}
