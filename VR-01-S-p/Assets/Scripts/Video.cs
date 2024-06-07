using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    VideoPlayer player;
    //public TMP_Text TextComp;
    public Sprite PauseSprite;
    public Image ButtonImage;
    Sprite PlaySprite;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        PlaySprite = ButtonImage.sprite;

        if (player.playOnAwake)
        {
            //TextComp.text = "Pause";
        }
        else
        {
            //TextComp.text = "Play";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            PlayButton();
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            StopButton();
        }
    }

    public void PlayButton()
    {
        if (player.isPlaying)
        {
            player.Pause();
            ButtonImage.sprite = PlaySprite;

            //TextComp.text = "Play";
        }
        else
        {
            player.Play();
            ButtonImage.sprite = PauseSprite;
            //TextComp.text = "Pause";
        }
    }
    public void StopButton()
    {
        player.Stop();
        ButtonImage.sprite = PlaySprite;
        //TextComp.text = "Play";


    }
    //public void PauseButton()
    //{
    //    player.Pause();
    //}
}
