using System;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public int player;
    public float velmov;
    public float velrot;
    public GameObject oruga;
    public GameObject mira;

    void Update()
    {
        Mira();
        Oruga();
        
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
