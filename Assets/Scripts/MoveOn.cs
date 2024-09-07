using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LetsGo(){
        SceneManager.LoadScene("HUh", LoadSceneMode.Single);
        Debug.Log("Hi!");
    }
}
