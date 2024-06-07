using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fizik : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Vector3 vec = Vector3.up;

        //    rigid.AddForce (vec * 10);
        //}
    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject go = collision.gameObject;

        Debug.Log(go.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }
}
