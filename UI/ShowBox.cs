using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowBox : MonoBehaviour {
    public Image showBoxBtn;
    public GameObject toolBox;
    //public Vector2 targetPosition;
    //private bool isFly = false;

    void Update()
    {
        
    }
    /// <summary>
    /// 隐藏弹出按钮，显示工具箱
    /// </summary>
    public void OnClick_ShowBox()
    {
        showBoxBtn.enabled = false;
        toolBox.SetActive(!toolBox.activeSelf);
        //isFly = true;
    }
}
