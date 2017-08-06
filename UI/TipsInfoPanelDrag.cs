using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TipsInfoPanelDrag : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    public RectTransform canvas;
    public Vector2 offSet;
    public GameObject tipsView;


    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mouseDown = eventData.position;
        Vector2 mouseUGUIPos = new Vector2();
        bool isRect = RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, mouseDown, eventData.enterEventCamera, out mouseUGUIPos);
        if (isRect)
        {
            tipsView.GetComponent<RectTransform>().anchoredPosition = offSet + mouseUGUIPos;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("GG");
        Vector2 mouseDown = eventData.position;
        Vector2 mouseUGUIPos = new Vector2();
        bool isRect = RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, mouseDown, eventData.enterEventCamera, out mouseUGUIPos);
        if (isRect)
        {
            offSet = tipsView.GetComponent<RectTransform>().anchoredPosition - mouseUGUIPos;
        }
    }
}
