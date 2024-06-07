using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Carpisma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;

        if (name.Contains("Barut"))
        {
            Destroy(gameObject);

            GameObject go = GameObject.Find("Manager");

            ScoreCounter counter = go.GetComponent<ScoreCounter>();
            counter.ScoreIncrement();
        }
       
    }
}
