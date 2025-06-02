using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Disparar : MonoBehaviour
{
    public float player;
    public Transform arma1;
    public Transform arma2;
    public Transform skill;
    public GameObject bullet;

    private void Update()
    {
        atacar();
    }

    private void atacar()
    {
        if (player == 1 && Input.GetButtonDown("FireQ"))
        {
            disparar1();
        }
        if (player == 2 && Input.GetButtonDown("Fire1"))
        {
            disparar1();
        }
    }
    private void disparar1() 
    {
        Instantiate(bullet, arma1.position, arma1.rotation);
    }

}
