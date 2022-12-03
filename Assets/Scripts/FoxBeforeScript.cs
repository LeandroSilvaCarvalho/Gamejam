using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxBeforeScript : MonoBehaviour
{
    [SerializeField]
    private GameObject foxAfter;
    private void Update()
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "FoxFire")
        {
            foxAfter.SetActive(true);
            gameObject.SetActive(false);
            //gameObject.GetComponent<BoxCollider>().enabled = false;
            //Transform foxTransform = transform;
            //Vector3 pos = foxTransform.position;
            //pos.x += 0.1f;
            //foxTransform.position = pos;

        }
    }
}
