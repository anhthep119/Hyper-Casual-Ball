using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 camFollow;
    private Transform ball, Win;
    private void Awake()
    {
        ball = FindObjectOfType<Ball>().transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Win == null)
            Win = GameObject.Find("Win(Clone)").GetComponent<Transform>();

        if (transform.position.y > ball.transform.position.y && transform.position.y > Win.position.y + 4f) 
            camFollow = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);

        transform.position = new Vector3(transform.position.x, camFollow.y, - 5);
        
    }
}
