using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propiedades_platillos : MonoBehaviour {
	public string nombre;
	public string precio;
	public string descripcion;
	public string estrellas;
	public string votos;

	public string id;
	public string caltotal;

	// Use this for initialization
	void Start () {
		clase_platillos Platillo= new clase_platillos();
		Platillo.Nombre=nombre;
		Platillo.Precio=precio;
		Platillo.Descripcion=descripcion;
		Platillo.Estrellas=estrellas;
		Platillo.Votos=votos;
		Platillo.Id=id;
		Platillo.Calificacion_Acumulada_Total=caltotal;

		global_variables.lista.Add(Platillo);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
