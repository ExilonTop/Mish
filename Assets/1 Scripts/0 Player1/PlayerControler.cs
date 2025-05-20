using System;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    
    public int hp=3;
    public int escudo=10;
    public int player;
    public float velmov;
    private float velrot;

    void Update()
    {
        Mira();
        Oruga();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bullet"))
        {
            escudo--; if(escudo==0)hp--;
        }
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
        /*Action funcion = () =>{
            float y =Input.GetAxis("Vertical"+ player.ToString())*Time.deltaTime;
            Vector3 posicion = transform.position;
            transform.localPosition += transform.up*velmov*y; 
        };
        funcion.Invoke();
        */
}
