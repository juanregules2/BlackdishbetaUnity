using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transladarplatillos : MonoBehaviour {
	bool izquierdabool=false;
	bool derechabool=false;

	// Use this for initialization
	public Transform barra;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(izquierdabool){
			barra.transform.Translate(1.55f,0,0);
		}
		if(derechabool){
		barra.transform.Translate(-1.55f,0,0);
		}
		
	}


	public void izquierda_down()
	{
		izquierdabool=true;
	}
	public void izquierda_up()
	{
		izquierdabool=false;
		
	}
	public void derecha_down()
	{
	derechabool=true;	
	}
	public void derecha_up()
	{
		derechabool=false;
	}
}
