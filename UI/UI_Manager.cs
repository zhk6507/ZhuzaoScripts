using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// 铸造模块按钮点击事件
    /// </summary>
    public void OnClick_Zhuzao()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// 返回首页
    /// </summary>
    public void OnClick_Back()
    {
        SceneManager.LoadScene(0);
    }
}
