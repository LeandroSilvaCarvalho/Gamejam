using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int hp;
    public GameObject Void;

    void Start()
    {
        
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            hp = hp + 1;
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        if (hp == 4)
        {
            Void.SetActive(true);
        }
    }
}
