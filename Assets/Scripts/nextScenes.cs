using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScenes : MonoBehaviour
{
    public string nameNextScene;

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nameNextScene);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nameNextScene);
        }
    }
}

