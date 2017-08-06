using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TipsUpdate : MonoBehaviour {
    private static TipsUpdate instance = new TipsUpdate();

    public static TipsUpdate Instance
    {
        get { return TipsUpdate.instance; }
    }
    private TipsUpdate() { }

    private Text tipsText;
    void Awake()
    {
        instance = this;        
    }
	// Use this for initialization
	void Start () {
        tipsText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// 更新提示栏里的内容
    /// </summary>
    /// <param name="content"></param>
    public void UpdateTipsText(string content)
    {
        tipsText.text = "\n"+content;
    }
}
