using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitItemDetection : MonoBehaviour
{
    [SerializeField] private ItemManager itemManager;
    private void OnTriggerEnter(Collider other)
    {
        itemManager.IncrementItem();
        Destroy(this.gameObject);
        //Debug.Log(itemManager.GetNbItemsCollected());
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        itemManager.IncrementItem();
        Destroy(this.gameObject);
    }
}
