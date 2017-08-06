using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class JiaoZhuXiTongJieshao : MonoBehaviour {

    public GameObject BG;
    public GameObject guanzhuxiangModel;
    public GameObject camer;
    [SerializeField]
    Button jiaozhujieshao;
	// Use this for initialization
	void Start () {
        jiaozhujieshao.onClick.AddListener(delegate
        {
            GoJiaoZhu();
            
            //if (!guanzhuxiangModel.gameObject.activeSelf)
            //{
            //    camer.GetComponent<MouseOrbit>().GoBackStart();
            //    camer.GetComponent<MouseOrbit>().enabled = BG.gameObject.activeSelf;
            //}
            
            //if (!camer.GetComponent<MouseOrbit>().enabled)
            //{
            //    camer.transform.DOLocalMove(new Vector3(-125.6531f, 1.010705f, -13.38601f), 1, false);
            //    camer.transform.DOLocalRotate(new Vector3(19.3554f, -2.1299f, 0.0013f), 1);
            //}
        });
	}
    /// <summary>
    /// 进入浇注系统介绍
    /// </summary>
    public void GoJiaoZhu()
    {
        BG.gameObject.SetActive(!BG.gameObject.activeSelf);
        guanzhuxiangModel.gameObject.SetActive(!guanzhuxiangModel.gameObject.activeSelf);
        camer.GetComponent<MoveCameraByMouse>().enabled = BG.gameObject.activeSelf;
        //camer.GetComponent<PlayerRoam>().enabled = false;
    }
    /// <summary>
    /// 退出浇注系统介绍
    /// </summary>
    public void ExitJiaoZhu()
    {
        BG.gameObject.SetActive(false);
        guanzhuxiangModel.gameObject.SetActive(false);
        camer.GetComponent<MoveCameraByMouse>().enabled = false;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
