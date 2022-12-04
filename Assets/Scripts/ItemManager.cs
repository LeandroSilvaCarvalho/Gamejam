using System.Collections;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static int nbItemsCOllected = 0;
    [SerializeField] private GameObject creature;
    [SerializeField] private Sprite newSprite;
    [SerializeField] private TextValue _textValue;
    private bool creatureRevealed = false;
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
        if (other.tag == "Player")
        {
            if (nbItemsCOllected >= 5)
            {
                //Debug.Log("Nice");
                if (creature != null)
                {
                    creature.gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
                    StartCoroutine(WaitCreature(0.5f));
                    
                }
            }
            else
            {
                //Debug.Log("Not nice");
            }
        }
    }

    private void Update()
    {
        if (creatureRevealed)
        {
            creature.transform.Translate(Vector3.left / 3);
        }
    }

    private IEnumerator WaitAndDestroyCreature(float sec)
    {
        creatureRevealed = true;
        yield return new WaitForSeconds(sec);
        Destroy(creature.gameObject);
        creatureRevealed = false;
    }

    private IEnumerator WaitCreature(float sec)
    {
        yield return new WaitForSeconds(sec);
        StartCoroutine(WaitAndDestroyCreature(10f));
    }

    public void IncrementItem()
    {
        nbItemsCOllected++;
        if (nbItemsCOllected > 5)
        {
            nbItemsCOllected = 1;
        }
        _textValue.UpdateText(nbItemsCOllected);
    }

    public int GetNbItemsCollected()
    {
        return nbItemsCOllected;
    }
}