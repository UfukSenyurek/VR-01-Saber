using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Morning : MonoBehaviour
{
    //public GameObject InputObject;
    //public GameObject TextObject;

    //public void GetText()
    //{
    //    TMP_InputField input = InputObject.GetComponent<TMP_InputField>();
    //    string veri = input.text;

    //    TMP_Text textComp = TextObject.GetComponent<TMP_Text>();
    //    textComp.text = veri;

    //    Debug.Log(veri);
    //}


    public TMP_InputField input;
    public TMP_Text textComp;

    public void VeriDegisti(string data)
    {
        textComp.text = data;
    }

    public void GetText()
    {
        string veri = input.text;

        textComp.text = veri;
    }


}
