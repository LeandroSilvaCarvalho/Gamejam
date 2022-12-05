using UnityEngine;

public class HitItemDetection : MonoBehaviour
{
    [SerializeField] private ItemManager itemManager;
    [SerializeField] private AudioClip audioSource;
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(audioSource, transform.position);
        itemManager.IncrementItem();
        Destroy(this.gameObject);
        //Debug.Log(itemManager.GetNbItemsCollected());
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource.PlayClipAtPoint(audioSource, transform.position);
        itemManager.IncrementItem();
        Destroy(this.gameObject);
    }
}
