using System.Collections;
using UnityEngine;

public class OutroManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AfterOutro());
    }

    private IEnumerator AfterOutro()
    {
        yield return new WaitForSeconds(64f);
        //SceneManager.LoadScene("StartScene");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
