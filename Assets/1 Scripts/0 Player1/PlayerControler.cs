using System;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    
    public float hp=3;
    public float player;
    public float velmov;
    public float velrot;

    void Update()
    {
        Mira();
        Oruga();
    }

    public void tomarDaño(float daño)
    {
        hp -= daño;
        if (hp == 0) Morir();    }

    public void Morir()
    {
        Destroy(this.gameObject);
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
