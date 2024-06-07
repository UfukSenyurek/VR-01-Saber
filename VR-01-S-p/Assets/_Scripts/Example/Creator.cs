using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public int ObjectCount;
    public GameObject PrefabObject;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < ObjectCount; i++)
        {
            GameObject go = GameObject.Instantiate(PrefabObject);
            go.name = "Balon" + i;

            float x = Random.Range(-25, 25);
            float y = Random.Range(0, 50);
            float z = Random.Range(-25, 25);

            go.transform.position = new Vector3(x, y, z);

            MeshRenderer renderer = go.GetComponent<MeshRenderer>();
            Material mat = renderer.material;
            mat.color = Random.ColorHSV();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
