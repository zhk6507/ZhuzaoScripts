using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;


public class CameraMoveNew : MonoBehaviour {
    public Button btn;
    public Vector3 targetPosition;
    public Vector3 targetRotation;
    public Transform cameras;
	
	void Start () {
        btn.onClick.AddListener(delegate
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
