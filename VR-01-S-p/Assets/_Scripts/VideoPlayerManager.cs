using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerManager : MonoBehaviour
{

    public VideoPlayer VideoPlayer;
    public bool IsPlayingNow = false;
    public float CurrentTime = 0;

     

    public Vector4 SkippingStep = new Vector4(0.5f, 0, 5.5f,0.2f);// Min - Current - Max - Acceleration
    [SerializeField]
    public test testerClass;

    [System.Serializable]
    public class test
    { public Vector3 SkippingStep; }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
       

    }
    public void CheckInputConsistency()
    {

    }
    public void GetKeybBoardInput( )
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PauseStart();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
          //  TimeSkip(SkipStepCurrent);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
           // TimeSkip(-SkipStepCurrent);
        }

    }
    public void PauseStart()
    {
        
        if(!VideoPlayer.isPlaying) 
        {
            VideoPlayer.Play();
        }
        else 
        {
            VideoPlayer.Pause();
        }
        
    }
    public void TimeSkip(float timeSkipAsSeconds)
    {
        Debug.Log("TU MADRE");
    }
    public void TimeSkip2(float timeSkipAsSeconds)
    {
        Debug.Log("TU MADRE2");
    }
}
