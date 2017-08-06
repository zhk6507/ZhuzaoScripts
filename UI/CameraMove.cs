using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class CameraMove : MonoBehaviour {
    private Button thisBtn;
    public Vector3 targetPosition;
    public Vector3 targetRotation;
    public Transform cameras;
	// Use this for initialization
	void Start () {
        thisBtn = GetComponent<Button>();
        thisBtn.onClick.AddListener(delegate
        {
            MoveCamera(targetPosition, targetRotation);
        });
	}

    public void MoveCamera(Vector3 targetPos, Vector3 targetRot)
    {
        cameras.DOMove(targetPos, 2, false);
        cameras.DORotate(targetRot, 2);
    }
	
	
}
