using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitItemDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

}
