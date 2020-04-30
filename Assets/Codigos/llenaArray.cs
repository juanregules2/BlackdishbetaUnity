using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class llenaArray : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//LEO LA LISTA DESDE EL PRINCIPIO Y LA AGREGO AL ARRAY

		StreamReader sr=new StreamReader(@".\Assets\Calificaciones\vv.txt");
		string revisa="";
	//QUITE RL1
	string revisas=sr.ReadLine();//solo dice S
	////Debug.Log("RL2:"+revisas);
		if(revisas=="S"){
		do{
			clase_platillos Platillo=new clase_platillos();
			
			string p=sr.ReadLine();//P
			Platillo.Id=sr.ReadLine();
			Debug.Log("agregado:"+Platillo.Id);
			////Debug.Log("RL3:"+Platillo.Id);
			Platillo.Nombre=sr.ReadLine();
			////Debug.Log("RL4:"+Platillo.Nombre);
			Platillo.Precio=sr.ReadLine();
			////Debug.Log("RL5:"+Platillo.Precio);
			Platillo.Descripcion=sr.ReadLine();
			////Debug.Log("RL6:"+Platillo.Descripcion);
			Platillo.Estrellas=sr.ReadLine();
			////Debug.Log("RL7:"+Platillo.Estrellas);
			Platillo.Votos=sr.ReadLine();
			////Debug.Log("RL8:"+Platillo.Votos);
			Platillo.Calificacion_Acumulada_Total=sr.ReadLine();
			//Debug.Log("RL9:"+Platillo.Calificacion_Acumulada_Total);

		global_variables.lista.Add(Platillo);

			


		}while(!sr.EndOfStream);

		sr.Close();
		}else{
			////Debug.Log("el txt esta vacio");
			sr.Close();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			for(int i=0;i<=global_variables.lista.Count-1;i++){
				clase_platillos Platillox=(clase_platillos)global_variables.lista[i];
				/*//Debug.Log(Platillox.Id);
				//Debug.Log(Platillox.Nombre);
				//Debug.Log(Platillox.Precio);
				//Debug.Log(Platillox.Descripcion);
				//Debug.Log(Platillox.Precio);
				//Debug.Log(Platillox.Estrellas);
				//Debug.Log(Platillox.Votos);
				//Debug.Log("//////ELEMENTOS 7"+Platillox.Id);
				*/

			}

		}
	}
}
