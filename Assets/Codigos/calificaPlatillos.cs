using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class calificaPlatillos : MonoBehaviour {
	public int califcacion_public;
	public Image starImage1;
	public Image starImage2;
	public Image starImage3;
	public Image starImage4;
	public Image starImage5;
	public Sprite circulitoR;
	public Sprite estrellitaR;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(global_variables.restartbool)
		{
			metodocalificarestart();
			global_variables.restartbool=false;
		}
	}
	public void metodocalificarestart(){
		starImage1.sprite=circulitoR;
			starImage2.sprite=circulitoR;
		starImage3.sprite=circulitoR;
		starImage4.sprite=circulitoR;
		starImage5.sprite=circulitoR;
	}
	public void metodoCalifica1(){
		starImage1.sprite=estrellitaR;
		starImage2.sprite=circulitoR;
		starImage3.sprite=circulitoR;
		starImage4.sprite=circulitoR;
		starImage5.sprite=circulitoR;
		calificaM2(1);

	}
	public void metodoCalifica2(){
			starImage1.sprite=estrellitaR;
		starImage2.sprite=estrellitaR;
		starImage3.sprite=circulitoR;
		starImage4.sprite=circulitoR;
		starImage5.sprite=circulitoR;
		calificaM2(2);
	}
	public void metodoCalifica3(){
		starImage1.sprite=estrellitaR;
		starImage2.sprite=estrellitaR;
		starImage3.sprite=estrellitaR;
		starImage4.sprite=circulitoR;
		starImage5.sprite=circulitoR;
		calificaM2(3);
	}
	public void metodoCalifica4(){
		starImage1.sprite=estrellitaR;
		starImage2.sprite=estrellitaR;
		starImage3.sprite=estrellitaR;
		starImage4.sprite=estrellitaR;
		starImage5.sprite=circulitoR;
		calificaM2(4);
	}
	public void metodoCalifica5(){
		starImage1.sprite=estrellitaR;
		starImage2.sprite=estrellitaR;
		starImage3.sprite=estrellitaR;
		starImage4.sprite=estrellitaR;
		starImage5.sprite=estrellitaR;
		calificaM2(5);

		//TEST
		/*
		StreamWriter Basededatosestrellas = new StreamWriter(@".\Assets\Calificaciones\vv.txt");
		Basededatosestrellas.WriteLine("BORRAR");
		Basededatosestrellas.Close();
		*/
	}
	public void calificaM2(int c){
		califcacion_public=c;
		//////Debug.Log("CAL:"+califcacion_public);
		int id_platillo=global_variables.platillo_actual;
		for(int i=0;i<=global_variables.lista.Count-1;i++){
			clase_platillos platillo_lista=(clase_platillos)global_variables.lista[i];
			string idplatillostring=platillo_lista.Id;
			//Debug.Log("idplatillo:"+idplatillostring);

			//DICE 2,4,1,5,P
			int idp=int.Parse(idplatillostring);
			//////Debug.Log(idplatillostring+" CALIFICAPLATILLOS.CS LN93");
			//ACTIVA LO QUE SIGUE:
			if(id_platillo==idp){

				//////Debug.Log("votos"+platillo_lista.Votos);
				//a la calificacion acumulada le sumo la calificacion actual
				if(platillo_lista.Calificacion_Acumulada_Total==""){
					platillo_lista.Calificacion_Acumulada_Total="0";
				}
				////Debug.Log("antes de double:"+platillo_lista.Calificacion_Acumulada_Total);
				//NO HAY NADA EN CALIFICACION ACUMULADA
				double caldouble=double.Parse(platillo_lista.Calificacion_Acumulada_Total);
				////Debug.Log("double:"+caldouble);
				caldouble+=califcacion_public;

				platillo_lista.Calificacion_Acumulada_Total=""+caldouble;
				////Debug.Log("dOUBLEJUAN:"+platillo_lista.Calificacion_Acumulada_Total);



					//////Debug.Log("%%%%%%%");
				//////Debug.Log("CALIFICA PLATILLOS LN 102:"+platillo_lista.Calificacion_Acumulada_Total);
				//////Debug.Log("%%%%%%%");

				int platillovotos=int.Parse(platillo_lista.Votos);
				platillovotos++;
				//////Debug.Log("calificaplatillos_LN103:"+platillovotos);
				int platillocalificacion_int=int.Parse(platillo_lista.Calificacion_Acumulada_Total);
				////Debug.Log("Xcalificaplatillos_LN105:"+platillocalificacion_int);
				////Debug.Log("X2:calString:"+platillo_lista.Calificacion_Acumulada_Total);
				double estrellasdouble=platillocalificacion_int/platillovotos;
				//////Debug.Log("calificaplatillos_LN107:"+estrellasdouble);
				platillo_lista.Votos=""+platillovotos;
				//////Debug.Log("calificaplatillos_LN109:"+platillo_lista.Votos);
				platillo_lista.Estrellas=""+estrellasdouble;
				//////Debug.Log("calificaplatillos_LN111:"+platillo_lista.Estrellas);
				////////Debug.Log("CA:"+platillo_lista.Calificacion_Acumulada_Total+"/P:"+platillo_lista.Nombre+"/Es:"+platillo_lista.Estrellas+"/V:"+platillo_lista.Votos);
			}


		}





		//DirectoryNotFoundException: Could not find a part of the path "C:\Users\Norman\OneDrive\Documentos\blackdish_minigame\Assets\Calificaciones\vv.txt".
		StreamWriter Basededatosestrellas = new StreamWriter(@".\Assets\Calificaciones\vv.txt");
		for(int i2=0;i2<=global_variables.lista.Count-1;i2++)
		{
			clase_platillos Platillo =(clase_platillos)global_variables.lista[i2];
				Basededatosestrellas.WriteLine("P");
					////Debug.Log("P");
				Basededatosestrellas.WriteLine(Platillo.Id);
					////Debug.Log("id:"+Platillo.Id);
				Basededatosestrellas.WriteLine(Platillo.Nombre);
					////Debug.Log("nombre:"+Platillo.Nombre);
				Basededatosestrellas.WriteLine(Platillo.Precio);
				
				////Debug.Log("precio:"+Platillo.Precio);
				Basededatosestrellas.WriteLine(Platillo.Descripcion);
					////Debug.Log("descripcion:"+Platillo.Descripcion);
				Basededatosestrellas.WriteLine(Platillo.Estrellas);
					////Debug.Log("estrellas:"+Platillo.Estrellas);
				Basededatosestrellas.WriteLine(Platillo.Votos);
					////Debug.Log("votos:"+Platillo.Votos);
				Basededatosestrellas.WriteLine(Platillo.Calificacion_Acumulada_Total);
					////Debug.Log("total:"+Platillo.Calificacion_Acumulada_Total);
			/*	//////Debug.Log("%%%%%%%");
				//////Debug.Log("CALIFICA PLATILLOS LN 135:"+Platillo.Calificacion_Acumulada_Total);
				//////Debug.Log("%%%%%%%");*/
		}
	
		//////Debug.Log(""+Basededatosestrellas);
		Basededatosestrellas.Close();
	

	}
}
