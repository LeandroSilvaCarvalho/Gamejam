using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    [SerializeField] private string newScene;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AfterIntro());
    }

    private IEnumerator AfterIntro()
    {
        yield return new WaitForSeconds(91f);
        SceneManager.LoadScene(newScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
