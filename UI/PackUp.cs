using UnityEngine;
using System.Collections;

public class PackUp : MonoBehaviour {
    /// <summary>
    /// 收起按钮栏
    /// </summary>
    public GameObject box;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick_Packup()
    {
        box.SetActive(!box.activeSelf);
    }
}
