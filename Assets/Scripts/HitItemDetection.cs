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
        Debug.Log(itemManager.GetNbItemsCollected());
    }

}
