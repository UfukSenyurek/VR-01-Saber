using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float speed = 0f;
    [Range(1.0f, 10.0f)]
    public float sensitivity = 1.0f;
    Vector3 pos = new Vector3 (0, 0, 0);

    float Yol = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //string metin = gameObject.name;
        //Debug.Log(metin);

        //Transform tr = GetComponent<Transform>();

        //Vector3 pos = tr.position;
        //Debug.Log(pos);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {

            float axisX = Input.GetAxis("Mouse X") * sensitivity;
            float axisY = Input.GetAxis("Mouse Y") * sensitivity;

            Quaternion q = transform.rotation;
            Vector3 rot = q.eulerAngles;

            rot.x -= axisY;
            rot.y += axisX;

            Quaternion q2 = Quaternion.Euler(rot);
            transform.rotation = q2;

            Yol = speed * Time.deltaTime;

            pos = transform.position;

            if (Input.GetKey(KeyCode.W))
            {
                Vector3 vec = Vector3.forward;
                vec = q2 * vec;
                pos = pos + vec * Yol;
            }
            if (Input.GetKey(KeyCode.S))
            {
                Vector3 vec = Vector3.forward;
                vec = q2 * vec;
                pos = pos - vec * Yol;
            }
            if (Input.GetKey(KeyCode.A))
            {
                Vector3 vec = Vector3.left;
                vec = q2 * vec;
                pos = pos + vec * Yol;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 vec = Vector3.right;
                vec = q2 * vec;
                pos = pos + vec * Yol;
            }
            if (Input.GetKey(KeyCode.E))
            {
                Vector3 vec = Vector3.up;
                vec = q2 * vec;
                pos = pos + vec * Yol;
            }
            if (Input.GetKey(KeyCode.Q))
            {
                Vector3 vec = Vector3.down;
                vec = q2 * vec;
                pos = pos + vec * Yol;
            }

            transform.position = pos;
        }
    }
}
