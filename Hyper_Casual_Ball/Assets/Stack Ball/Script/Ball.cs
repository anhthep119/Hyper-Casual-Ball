using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private bool smash;
     void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        smash = true;
        if (Input.GetMouseButtonUp(0))
            smash = false;
    }
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            smash = true;
            rb.velocity = new Vector3(0,-100 * Time.fixedDeltaTime * 7, 0);
        }
        if(rb.velocity.y > 5)
        {
            rb.velocity = new Vector3 (rb.velocity.x, 5, rb.velocity.z);
        }
    }
    void OnCollisionEnter(Collision target)
    {
        if(!smash)
        {
            rb.velocity = new Vector3(0, 50 * Time.deltaTime * 5,0);
        }
    }
    void OnCollisionStay(Collision target)
    {
        if(!smash || target.gameObject.tag == "Finish")
        {
            rb.velocity = new Vector3(0, 50 * Time.deltaTime *5, 0);
        }
    }
}
