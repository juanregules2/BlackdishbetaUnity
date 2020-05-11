using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvascode : MonoBehaviour {
	public RectTransform canvass;
	public Image imagenbase;
	float canvas_X;
	float canvas_Y;
	// Use this for initialization
	void Start () {
		canvas_X = canvass.sizeDelta.x;
		canvas_Y = canvass.sizeDelta.y;
	}
	
	// Update is called once per frame
	void Update () {
		canvas_X = canvass.sizeDelta.x;
		canvas_Y = canvass.sizeDelta.y;

		imagenbase.rectTransform.localScale=new Vector3(canvas_X/100,canvas_Y/100,0);
		imagenbase.rectTransform.position = new Vector3 (0, 0, 0);

		
	}

	//poner la imagen base
	//poner la imagen ganado

	/*
KEYSTORE:
c:/9 semestre/Rolling 15/Rolling.keystore

	*/
}