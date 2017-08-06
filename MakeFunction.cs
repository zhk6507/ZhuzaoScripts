using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Text;
/// <summary>
/// 挖沙造型方法过程，此脚本也可用于其他造型方法
/// </summary>
public class MakeFunction : MonoBehaviour {
    public Button btn_Zaoxing;
    public string name_zaoxing = "WashaToolGrid";
    public Transform toolbox;
    public ScrollRect toolboxes;
    //实例化工具之后跟随鼠标移动开关
    public bool isFollow = false;
    //进入模拟铸造开关
    public bool inStep = false;
    //当前步骤
    public int currentStep=0;
    //当前选中的工具名称
    public string currentToolName;
    //操作步骤文本
    private string[] stepText;
    //操作所需工具文本
    private string[] toolText;
    
	//Use this for initialization
	void Start () {
        ReadTxtFileByLine();//读取文件
        btn_Zaoxing.onClick.AddListener(delegate
        {
            LoadTools(name_zaoxing);
            inStep = !inStep;
            TipsUpdate.Instance.UpdateTipsText(stepText[currentStep]);
        });
	}
    void Update()
    {
        if (inStep)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    //点一下地板取消工具
                    if (!hit.collider.CompareTag("Point"))
                    {
                        currentToolName = "手";
                    }
                    else
                    {
                        ChoiceAnim();
                    }

                }
            }
        }
    }
 
    /// <summary>
    /// 加载工具进工具箱
    /// </summary>
    /// <param name="name_zaoxing"></param>
    private void LoadTools(string name_zaoxing)
    {
        if (toolbox.childCount == 0)
        {
            GameObject go = Resources.Load<GameObject>(name_zaoxing);
            Transform temp = Instantiate<GameObject>(go).transform;
            temp.parent = toolbox;
            temp.localPosition = Vector3.zero;
            toolboxes.content = temp.GetComponent<RectTransform>();
        }
    }
    /// <summary>
    /// 实例化工具
    /// </summary>
    /// <param name="toolName"></param>
    Transform toolInstance;
    public void ToolInstant(string toolName)
    {
        //Destroy(toolInstance.gameObject);
        GameObject go = Resources.Load<GameObject>("Tools/" + toolName);
        toolInstance = Instantiate<GameObject>(go).transform;
        currentToolName = toolName;
        isFollow = true;
        StartCoroutine("ToolFollowMouse", toolInstance);
        StartCoroutine(GoStep());
    }
    /// <summary>
    /// 实例化出来的工具跟随鼠标移动
    /// </summary>
    /// <param name="toolInstance"></param>
    /// <returns></returns>
    IEnumerator ToolFollowMouse(Transform toolInstance)
    {
        while(isFollow)
        {
            toolInstance.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward*2);
            if (Input.GetMouseButtonDown(0))
            {
                isFollow = false;
                Destroy(toolInstance.gameObject);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    //点一下地板取消工具
                    if (!hit.collider.CompareTag("Point"))
                    {
                        currentToolName = "手";
                        //StartCoroutine(GoStep());
                    }
                }
                //Debug.Log(currentToolName);
            }
            yield return null;
        }
    }
    /// <summary>
    /// 控制流程
    /// </summary>
    /// <returns></returns>
    IEnumerator GoStep()
    {
        //Debug.Log("GoStep");
        while(inStep)
        {
            //Debug.Log("inStep");
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray,out hit))
                {
                    if (hit.collider.CompareTag("Point"))
                    {
                        ChoiceAnim();
                        Debug.Log("当前工具" + currentToolName);
                        break;
                    }
                    else
                    {
                        //取消工具就点一下地板
                        currentToolName = "手";
                        ChoiceAnim();
                        break;
                    }
                }
            }
            yield return null;
        }
        
    }
    /// <summary>
    /// 判断是否播放动画
    /// </summary>
    [SerializeField]
    Animator anim;
    AnimatorStateInfo animInfo;
    void  ChoiceAnim()
    {
        if (currentStep < stepText.Length)
        {
            if (currentStep < stepText.Length -1&& currentToolName == toolText[currentStep])
            {
                //Debug.Log("选对了");
                anim.SetTrigger("PlayNext");
                //StartCoroutine(IsOver());
                animInfo = anim.GetCurrentAnimatorStateInfo(0);
                if (animInfo.normalizedTime >= 1.0f)
                {
                    //Debug.Log("Take" + (currentStep + 1));
                    currentStep++;
                    
                }
            }
                TipsUpdate.Instance.UpdateTipsText(stepText[currentStep]);
           
        }
        else
        {
            //退出流程
            inStep = false;
            Debug.Log("111");
        }
        
    }
    /// <summary>
    /// 等待动画播放结束
    /// </summary>
    /// <returns></returns>
    //bool isOver = false;
    //IEnumerator IsOver()
    //{
    //    while (isOver)
    //    {
            
    //    }
    //    animInfo = anim.GetCurrentAnimatorStateInfo(0);
    //    yield return new WaitUntil(() => animInfo.normalizedTime >= 1.0);
    //    currentStep++;
    //}
    /// <summary>
    /// 逐行读取txt,存入数组
    /// </summary>
    public void ReadTxtFileByLine()
    {
        //文本路径
        string path1 = Application.dataPath + "/Resources/Step.txt";
        string path2 = Application.dataPath + "/Resources/tool.txt";
        try
        {
            //逐行读取文件，放进数组
            stepText = File.ReadAllLines(path1);
            toolText = File.ReadAllLines(path2);
        }
        catch (System.Exception)
        {
            Debug.Log("读取文件失败！");
        }
    }
}
