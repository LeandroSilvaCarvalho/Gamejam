using UnityEngine;

public class FoxAfterScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    Transform foxTransform;
    // Start is called before the first frame update
    void Start()
    {
        foxTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = foxTransform.position;
        pos.x += moveSpeed;
        foxTransform.position = pos;
        if(pos.x <= -300)
        {
            Destroy(gameObject);
        }
    }
}
