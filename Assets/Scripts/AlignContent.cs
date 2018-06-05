using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignContent : MonoBehaviour {
    public Vector3 position = new Vector3(0, 0, 0);
    // Use this for initialization
    private RectTransform rect;

    void Start () {
        rect = GetComponent<RectTransform>();

    }
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 aux = new Vector3(position.x, rect.anchoredPosition.y, position.z);
        rect.anchoredPosition = aux;
    }
}
