using System;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public List<GameObject> items;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
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
