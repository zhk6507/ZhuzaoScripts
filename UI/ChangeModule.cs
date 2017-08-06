using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 切换功能模块
/// </summary>
public class ChangeModule : MonoBehaviour
{
    public Toggle btn1;
    public Toggle btn2;
    public Toggle btn3;
    public Toggle btn4;

    public GameObject Module1;
    public GameObject Module2;
    public GameObject Module3;
    public GameObject Module4;

    public GameObject leftMenu1;
    public GameObject leftMenu2;
    public GameObject leftMenu3;
    public GameObject leftMenu4;

    public Button btn_Left;
    public Button btn_Right;

    public GameObject btn_jiaozhu;
    [SerializeField]
    GameObject jiaozhuManager;
	void Start () {       
        btn1.onValueChanged.AddListener(delegate(bool isOn)
        {

            initModule1(isOn);
            initModule4(false);
            jiaozhuManager.GetComponent<JiaoZhuXiTongJieshao>().ExitJiaoZhu();
        });
        btn2.onValueChanged.AddListener(delegate(bool isOn)
        {
            initModule2(isOn);
            initModule4(false);
        });
        btn3.onValueChanged.AddListener(delegate(bool isOn)
        {
            initModule3(isOn);
            initModule4(false);
            jiaozhuManager.GetComponent<JiaoZhuXiTongJieshao>().ExitJiaoZhu();
        });
        btn4.onValueChanged.AddListener(delegate(bool isOn)
        {
            initModule1(false);
            initModule2(false);
            initModule3(false);
            initModule4(isOn);
            jiaozhuManager.GetComponent<JiaoZhuXiTongJieshao>().ExitJiaoZhu();
        });

        btn_Left.onClick.AddListener(delegate
        {
            //GetComponent<ScrollRect>().horizontalNormalizedPosition = 0;
            btn1.gameObject.SetActive(true);
            btn2.gameObject.SetActive(true);
            btn3.gameObject.SetActive(true);
            btn4.gameObject.SetActive(false);
            //btn4.GetComponent<Renderer>().enabled = false;
        });
        btn_Right.onClick.AddListener(delegate
        {
            //GetComponent<ScrollRect>().horizontalNormalizedPosition = 1;
            btn1.gameObject.SetActive(false);
            btn2.gameObject.SetActive(false);
            btn3.gameObject.SetActive(false);
            btn4.gameObject.SetActive(true);
            //btn4.GetComponent<Renderer>().enabled = true;
        });
     
        
	}

    private void initModule1(bool isOn)
    {
        Module1.SetActive(isOn);
        leftMenu1.SetActive(isOn);
    }
    private void initModule2(bool isOn)
    {
        Module2.SetActive(isOn);
        leftMenu2.SetActive(isOn);
    }
    private void initModule3(bool isOn)
    {
        Module3.SetActive(isOn);
        leftMenu3.SetActive(isOn);
    }
    private void initModule4(bool isOn)
    {
        Module4.SetActive(isOn);
        leftMenu4.SetActive(isOn);
    }
	
}
