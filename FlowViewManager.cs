using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FlowViewManager : MonoBehaviour {
    public Button tuzhiBtn;
    public Button moyangBtn;
    public Button ZaoxingBtn;

    public Image tuzhiImage;
    public RawImage moyang;
    //小相机的初始化位置
    public Vector3 initpos;
    public Quaternion initrot;
    public Vector3 ro;

    [SerializeField]
    GameObject mianCamera;
    [SerializeField]
    Transform camera;
	void Start () {
        initpos = camera.position;
        //initrot = camera.rotation;
        ro = camera.rotation.eulerAngles;

        tuzhiBtn.onClick.AddListener(delegate
        {
            tuzhiImage.gameObject.SetActive(!tuzhiImage.gameObject.activeSelf);
            moyang.gameObject.SetActive(false);
            mianCamera.GetComponent<PlayerRoam>().enabled = true;
        });
        moyangBtn.onClick.AddListener(delegate
        {
            moyang.gameObject.SetActive(!moyang.gameObject.activeSelf);
            tuzhiImage.gameObject.SetActive(false);
            mianCamera.GetComponent<PlayerRoam>().enabled = !moyang.gameObject.activeSelf;
            initCameraPos();
        });
        ZaoxingBtn.onClick.AddListener(delegate
        {
            moyang.gameObject.SetActive(false);
            tuzhiImage.gameObject.SetActive(false);
            mianCamera.GetComponent<PlayerRoam>().enabled = true;
        });
	}
    /// <summary>
    /// 初始化相机位置
    /// </summary>
    private void initCameraPos()
    {
        camera.position = initpos;
        //camera.rotation = initrot;
        camera.rotation = Quaternion.Euler(ro);
        Debug.Log(initpos);
        Debug.Log(initrot);
        Debug.Log("初始化成功！");
    }
}
