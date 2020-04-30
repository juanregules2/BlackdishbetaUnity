using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuestraSelect : MonoBehaviour {

public Text textotitulo;
public Text textoprecio;
public Text textodescripcion;

public Text textocalificacion;

public SpriteRenderer imagenmuestra;
public int id_platillo;
public Image imagenbase;
	// Use this for initialization
	void Start () {
		global_variables.platillo_actual=0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void muestraPlatillo(){
		imagenmuestra.sprite=imagenbase.sprite;
		global_variables.platillo_actual=id_platillo;
		////Debug.Log("platillo actual:"+global_variables.platillo_actual);
		global_variables.restartbool=true;
		for(int i=0;i<=global_variables.lista.Count-1;i++){
			clase_platillos platillo=(clase_platillos)global_variables.lista[i];
			string sID=id_platillo+"";
			if(sID==platillo.Id){
				textotitulo.text=platillo.Nombre;
				textodescripcion.text=platillo.Descripcion;
				textoprecio.text=platillo.Precio;
				double calificaciontotal_estrellas=0;
				int total=int.Parse(platillo.Calificacion_Acumulada_Total);
				int votos=int.Parse(platillo.Votos);
				calificaciontotal_estrellas=total/votos;
				textocalificacion.text=""+calificaciontotal_estrellas+"("+votos+")";
			}


		}

	}
}
