using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject horace;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - horace.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = horace.transform.position + offset;
	}
}
