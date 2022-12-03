using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    
    private static int nbItemsCOllected = 0;
    [SerializeField] private GameObject creature;
    [SerializeField] private Sprite newSprite;
    public static ItemManager Instance { get; private set; }
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
    
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (nbItemsCOllected >= 5)
        {
            Debug.Log("Nice");
            creature.gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
        else
        {
            Debug.Log("Not nice");
        }
    }

    public void IncrementItem()
    {
        nbItemsCOllected++;
    }

    public int GetNbItemsCollected()
    {
        return nbItemsCOllected;
    }
}
