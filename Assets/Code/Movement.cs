using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public Animator anim;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //animations
        if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            anim.SetTrigger("Walk");
        }
        if (!Input.anyKey)
        {
            anim.SetTrigger("Idle");
        }
        //movements
        if (Input.GetKey("w"))
        {
            //rb.AddForce(0, 0, 1500f * Time.deltaTime);
            transform.position += new Vector3(0, 0, 0.02f);
        }
        if (Input.GetKey("a"))
        {
            //rb.AddForce(-500f * Time.deltaTime, 0, 0);
            transform.position += new Vector3(-0.01f, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            //rb.AddForce(0, 0, -1000f * Time.deltaTime);
            transform.position += new Vector3(0, 0, -0.01f);
        }
        if (Input.GetKey("d"))
        {
            //rb.AddForce(500f * Time.deltaTime, 0, 0);
            transform.position += new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            //rb.AddForce(500f * Time.deltaTime, 0, 0);
            transform.position += new Vector3(0, 0.5f, 0);
            transform.position += new Vector3(0, 0.5f, 0);
        }
    }
}
