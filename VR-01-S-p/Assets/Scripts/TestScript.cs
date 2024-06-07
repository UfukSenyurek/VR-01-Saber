using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject go;
    public MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {


        //MeshFilter filter = GetComponent<MeshFilter>();
        //Mesh asd = filter.mesh;

        //MeshRenderer renderer = GetComponent<MeshRenderer>();
        //Material mat = renderer.material;
        ////mat.color = Color.red;
        //mat.color = Random.ColorHSV();

        //BoxCollider collider = GetComponent<BoxCollider>();
        //Vector3 vec = new Vector3(0, 1, 2);
        //collider.center = vec;

        //Rigidbody rigid = gameObject.AddComponent<Rigidbody>();
        //rigid.useGravity = false;







        //GameObject go = GameObject.Find("RightCube");

        //Transform tr = go.GetComponent<Transform>();

        //Vector3 pos = tr.position;
        //pos.y = pos.y + 2;
        //tr.position = pos;

        //MeshRenderer renderer = go.GetComponent<MeshRenderer>();
        Material mat = renderer.material;
        mat.color = Color.red;







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
