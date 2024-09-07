using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{   public Transform player;
    Vector3 posoffset = new Vector3 (0,3f,-3f);
    private float smoothTime = 0.05f;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //transform.position = player.position + Campos;
            Vector3 playerPos = player.position + posoffset;
            transform.position = Vector3.SmoothDamp(transform.position, playerPos, ref velocity, smoothTime);
    }
}
