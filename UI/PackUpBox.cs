using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PackUpBox : MonoBehaviour {
    public Button packup_Btn;
    //public Vector3 targetPosion;
    public GameObject toolBox;
    public Image showBoxBtn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick_packup_Btn()
    {
        //toolBox.localPosition = targetPosion;
        showBoxBtn.enabled = true;
        toolBox.SetActive(false);
    }
}
