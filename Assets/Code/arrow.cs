using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    bool up;
    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        else
            transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Directional")
        {
            up = !up;
        }
    }
}
