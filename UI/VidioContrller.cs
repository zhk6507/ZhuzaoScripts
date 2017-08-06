using UnityEngine;
using System.Collections;
using RenderHeads.Media.AVProVideo.Demos;
using UnityEngine.UI;

public class VidioContrller : MonoBehaviour {
    private bool isPlay = false;
    public VCR vcr;
	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(delegate
        {
            isPlay = GetComponent<ChangeImage>().isOn;
            PlayOrPause(isPlay);
        });
	}
  
    public void PlayOrPause(bool isPlay)
    {
        if (isPlay)
        {
            vcr.OnPlayButton();
        }
        else
        {
            vcr.OnPauseButton();
        }
    }
	
}
