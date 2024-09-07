using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TrippedDetect : MonoBehaviour
{   public Camera mainCam;
    public Camera EndCam;
    public Button Restart;
    public TextMeshProUGUI  Rtext;
    
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
        //Debug.Log("Tripped!");
        EndCam.enabled = true;
        //Camera.main.enabled = false;
        mainCam.enabled = false;
        Restart.enabled = true;
        Rtext.enabled = true; 
    }
}
