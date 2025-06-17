using System;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public bool meChoco;
    public List<GameObject> items;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (meChoco == false && collision.CompareTag("bullet"))
        {
            meChoco = true;
            if (items.Count > 0)
            {
                int index = UnityEngine.Random.Range(0, items.Count);
                Instantiate(items[index], transform.position, quaternion.identity);
            }
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
        }
        
    }
}
