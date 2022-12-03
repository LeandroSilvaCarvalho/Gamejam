using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxScript : MonoBehaviour
{
    [SerializeField]
    private GameObject FoxAfter;
    private void OnTriggerEnter(Collider other)
    {
        //if (ElementCount.counts != 5) return;
        FoxAfter.SetActive(true);
        gameObject.SetActive(false);
    }
}
