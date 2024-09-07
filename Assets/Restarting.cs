using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restarting : MonoBehaviour
{   public Transform playerPos;
    public Camera ECam;
    public Camera MainCam;
    public TextMeshProUGUI Rtext;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 resetPos = new Vector3 (-2.26f, -3.53f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reset()
    {   //Vector3 resetPos = new Vector3 (-2.26f, -3.53f, 0);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Rtext.enabled = false;
        ECam.enabled = false;
        MainCam.enabled = true;
    }
}
