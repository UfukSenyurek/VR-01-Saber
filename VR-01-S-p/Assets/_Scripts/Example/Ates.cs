using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    public GameObject Bullet;
    public float ForceFactor = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = GameObject.Instantiate(Bullet);
            go.transform.position = transform.position;

            Rigidbody rb = go.GetComponent<Rigidbody>();

            Vector3 vec = transform.forward;
            rb.AddForce(vec * 1000 * ForceFactor);
        }
    }
}
