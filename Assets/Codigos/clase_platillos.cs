using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clase_platillos : MonoBehaviour {

	private string nombre;
	private string precio;
	private string descripcion;
	private string estrellas;
	private string votos;
	private string id;
	private string calificacion_acumulada_total;


	public string Calificacion_Acumulada_Total{
			get{ return calificacion_acumulada_total;}
		set{calificacion_acumulada_total=value;}
	}

	public string Id{
			get{ return id;}
		set{id=value;}
	}


	public string Nombre{
		get{ return nombre;}
		set{nombre=value;}
	}

	public string Precio{
		get{ return precio;}
		set{precio=value;}
	}
	public string Descripcion{
		get{ return descripcion;}
		set{descripcion=value;}
	}
	public string Estrellas{
		get{ return estrellas;}
		set{estrellas=value;}
	}
	public string Votos{
		get{ return votos;}
		set{votos=value;}
	}

	public clase_platillos(){
		nombre="";
		precio="";
		descripcion="";
		estrellas="";
		votos="";
		id="";
		calificacion_acumulada_total="";


	}

	public clase_platillos(string n, string p, string d, string e, string v, string i, string ct){
		nombre=n;
		precio=p;
		descripcion=d;
		estrellas=e;
		votos=v;
		id=i;
		calificacion_acumulada_total=ct;
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
