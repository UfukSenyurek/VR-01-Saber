using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Donus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion q = transform.rotation;
        //Vector3 rot = q.eulerAngles;

        //Debug.Log(rot);

        Vector3 rot = new Vector3(0, 30, 0);
        Quaternion q = Quaternion.Euler(rot);

        transform.rotation = q;
        
    }
}
