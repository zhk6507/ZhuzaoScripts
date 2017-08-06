using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowTips : MonoBehaviour
{
    private bool isShow;
    public RectTransform tipsView;
    public Vector2 targetPositionOfHide;
    public Vector2 targetPositionOfShow;

    //public float zhi;
    void Start()
    {
        //currentPosition = tipsView.anchoredPosition;
        //StartCoroutine("Fly");
    }
    void Update()
    {
        isShow = GetComponent<ChangeImage>().isOn;
        if (isShow)
        {
            //Debug.Log("显示提示");
            //tipsView.enabled = isShow;
            //tipsView.localPosition = new Vector3(0f, 192.5f, 0f);
            tipsView.anchoredPosition = Vector2.Lerp(tipsView.anchoredPosition, targetPositionOfShow, 0.5f);
        }
        else
        {
            //tipsView.enabled = false;
            //tipsView.localPosition = new Vector3(0f, 450f, 0f);
            tipsView.anchoredPosition = Vector2.Lerp(tipsView.anchoredPosition, targetPositionOfHide, 0.5f);
        }
    }

    //IEnumerable Fly()
    //{
    //    if (GetComponent<ChangeImage>().isOn)
    //    {
    //        if (zhi > 0)
    //        {
    //            zhi -= 0.1f;
    //            if (zhi<=0)
    //            {
    //                zhi = 0;
    //            }
    //        }
            
    //    }
    //    else
    //    {
    //        if (zhi<1)
    //        {
    //            zhi += 0.1f;
    //            if (zhi>=1)
    //            {
    //                zhi = 1;
    //            }
    //        }
    //    }
    //    yield return 0;
    //}
}
