using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D (Collision2D other)
    {
        SceneManager.LoadScene("End Scene", LoadSceneMode.Single);
    }
    public void beginAgain()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
