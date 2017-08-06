using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using RenderHeads.Media.AVProVideo;


public class WorkTheoryAnim : MonoBehaviour {
    public Button zhenshiBtn;
    public Button yashiBtn;
    public Button bamoBtn;
    public Animator animZaoxingji;
    public MediaPlayer media;

	void Start () {
        zhenshiBtn.onClick.AddListener(delegate
        {
            media.m_VideoPath = "ZhenShi.mp4";
            media.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, media.m_VideoPath, true);
            animZaoxingji.SetBool("PlayYaShi", false);
            animZaoxingji.SetBool("PLayBaMo", false);
            animZaoxingji.SetBool("PlayZhenShi", true);
        });
        yashiBtn.onClick.AddListener(delegate
        {

            media.m_VideoPath = "YaShi.mp4";
            media.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, media.m_VideoPath, true);
            animZaoxingji.SetBool("PlayBaMo", false);
            animZaoxingji.SetBool("PlayZhenShi", false);
            animZaoxingji.SetBool("PlayYaShi", true);
        });
        bamoBtn.onClick.AddListener(delegate
        {

            media.m_VideoPath = "BaMo.mp4";
            media.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, media.m_VideoPath, true);
            animZaoxingji.SetBool("PlayZhenShi", false);
            animZaoxingji.SetBool("PlayYaShi", false);
            animZaoxingji.SetBool("PlayBaMo", true);
        });

	}
	
}
