using System;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public float velmov;
    public float velrot;
    public GameObject oruga;
    public GameObject mira;

    void Update()
    {
        Oruga();
        Mira();
    }

    public void Oruga()
    {
        
        float y =Input.GetAxis("Vertical")*Time.deltaTime;
        Vector3 posicion = transform.position;
        transform.position=new Vector3(posicion.x, y*velmov+posicion.y, posicion.z);
        
    }
    private void Mira()
    {
        float x =Input.GetAxis("Horizontal")*Time.deltaTime;
        Quaternion rotation = transform.localRotation;
        rotation.eulerAngles=new Vector3(0,0,-1*x*velrot + rotation.eulerAngles.z);
        transform.localRotation = rotation;
        
    }

}
