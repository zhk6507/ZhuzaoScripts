using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectTool : MonoBehaviour {
    private Button toolItem;
    private Text toolNameText;
    private MakeFunction makeFunction;
	// Use this for initialization
	void Start () {
        toolItem = GetComponent<Button>();
        toolNameText = GetComponentInChildren<Text>();

        toolItem.onClick.AddListener(delegate
        {
            //makeFunction = GameObject.Find("ChangYongPanel/LeftPanel").GetComponent<MakeFunction>();
            makeFunction = GameObject.Find("WashaManager").GetComponent<MakeFunction>();
            makeFunction.ToolInstant(toolNameText.text);
        });
	}
	
}
