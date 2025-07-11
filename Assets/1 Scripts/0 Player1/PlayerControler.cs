using System;
using TMPro;
using UnityEngine;
public class PlayerControler : MonoBehaviour
{
    public float hp=50;
    public float hpMax=50;
    public float player;
    public float velmov;
    public float velrot;
    public GameObject ganador;
    public TMP_Text vida; // 
    void Update()
    {
        Mira();
        Oruga();
        vida.text = hp.ToString();
    }
    public void tomarDaño(float daño)
    {
        hp -= daño;
        if (hp <= 0) Morir();
    }
    public void tomarVida(float vida)
    {
        hp = Mathf.Min(hp + vida, hpMax);
    }
    public void Morir()
    {
        if(player==1){ganador.GetComponent<Pausa>().quienGano2();}
        if(player==2){ganador.GetComponent<Pausa>().quienGano();}
    }
    public void Oruga()
    {
        float y =Input.GetAxis("Vertical"+ player.ToString())*Time.deltaTime;
        Vector3 posicion = transform.position;
        transform.localPosition += transform.up*velmov*y;   
    }
    private void Mira()
    {
        float x =Input.GetAxis("Horizontal"+player.ToString())*Time.deltaTime;
        Quaternion rotation = transform.localRotation;
        rotation.eulerAngles=new Vector3(0,0,-1*x*velrot + rotation.eulerAngles.z);
        transform.localRotation = rotation;
    }
}
