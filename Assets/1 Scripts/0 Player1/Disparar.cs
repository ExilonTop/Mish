using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
    public WeaponData currentWeaponIzq;
    public Transform armaizq;
    public List<Bala> armasIzq = new List<Bala>();
    [Header("ArmaDer")]
    public WeaponData currentWeaponDer;
    public Transform armader;
    public List<Bala> armasDer = new List<Bala>();
    private void Update()
    {
        if (Time.timeScale==0)
        {
            canDispararDer=false;
            canDispararIzq=false;
        }

        if (canDispararIzq == true)
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
    public void DispararGeneric(WeaponData weaponData, List<Bala> balas, Transform spawnPoint)
    {
        if (weaponData.bulletIndex >= 0 && weaponData.bulletIndex < balas.Count)
        {
            Bala bala = Instantiate(balas[weaponData.bulletIndex], spawnPoint.position, spawnPoint.rotation);
            bala.Shoot();
        }
        
    
    }
}
