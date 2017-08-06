using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JiaoZhuSystemManager : MonoBehaviour {
    public Button btn_Lengt;
    public Button btn_Jiaozhu;
    public Button btn_Butie;

    public GameObject videoPlayerLengt;
    public GameObject guanzhuxiangModel;
    [SerializeField]
     GameObject cameras;
	// Use this for initialization
	void Start () {
        btn_Lengt.onClick.AddListener(delegate
        {
            videoPlayerLengt.gameObject.SetActive(!videoPlayerLengt.activeSelf);
            GetComponent<JiaoZhuXiTongJieshao>().ExitJiaoZhu();
            cameras.GetComponent<PlayerRoam>().enabled = true;

        });
        btn_Jiaozhu.onClick.AddListener(delegate
        {
            videoPlayerLengt.gameObject.SetActive(false);
            //offJiaoZhu = !offJiaoZhu;
            cameras.GetComponent<PlayerRoam>().enabled = !guanzhuxiangModel.gameObject.activeSelf;
        });
        btn_Butie.onClick.AddListener(delegate
        {
            videoPlayerLengt.gameObject.SetActive(false);
            GetComponent<JiaoZhuXiTongJieshao>().ExitJiaoZhu();
            cameras.GetComponent<PlayerRoam>().enabled = true;
        });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
