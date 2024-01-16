using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class vbButton : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject[] myButtons;
    public GameObject confirmPanel;
    public GameObject videoPlane;
    private bool isVideoPlaying = false;
    private VideoPlayer video;
   
    // Use this for initialization
    void Start () {
		for(int i=0; i < myButtons.Length ; i++)
        {
            myButtons[i].GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        }
        video = videoPlane.GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.name == "buttonT3")
        {
            confirmPanel.SetActive(true);
        }
        if (vb.name == "buttonT1Start" && isVideoPlaying == false)
        {
            video.Play();
            isVideoPlaying = true;
        }
        if (vb.name == "buttonT1Sop" && isVideoPlaying == true)
        {
            video.Stop();
            isVideoPlaying = false;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }
}
