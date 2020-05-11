using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class membresia : MonoBehaviour

{
    bool yachequemembresiabool=false;
    
    int depurado=0;

    bool membresiapagada=false;//BOOL LOCAL que inidica si esta pagada la membresia
    public GameObject cuadroblanco;//imagen local que cubre la pantalla

    public GameObject ARgameobject;//si no ha pagado membresia, desactiva el AR
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetText());

        
    }

    // Update is called once per frame
    void Update()
    {


            //PRUEBAS
            //DESACTIVA ESTO CUANDO SIRVA EL BACKEND
            depurado=1;//DESACTIVA ESTO CUANDO SIRVA EL BACKEND

        //evaluacion continua del bool para activar o desactivar el cuadro que cubre la pantalla
        if(!yachequemembresiabool){
        if(depurado==1){

            //DESACTIVA LOS COMENTARIOS
            //si pago membresia
               cuadroblanco.SetActive(false);
                ARgameobject.SetActive(true);
                Debug.Log("membresia activada");

        }else{

            //no pago membresia
            cuadroblanco.SetActive(true);
            ARgameobject.SetActive(false);
            Debug.Log("membresia no activada");
        }
        yachequemembresiabool=true;
        }
        
    }
   



    

   IEnumerator GetText(){
       //Debug.Log("entrando");
       // Access a website and use UnityWebRequest.Get to download a page.
       using(UnityWebRequest www = UnityWebRequest.Get("https://blackdish.mx/blackdish-beta-v3/api/controller.php")){
           yield return www.SendWebRequest();

           if(www.isNetworkError || www.isHttpError){

               Debug.Log("errore en networ:"+www.error);
               

           }else{
               
               //Debug.Log(www.downloadHandler.text);
               string txt=www.downloadHandler.text;
               //Debug.Log("respuesta:"+txt);
               //Debug.Log("rrrrrrrrrrrrrrrrrr");
               //Debug.Log("rrrrrrrrrrrrrrrrrr");
                //el resultado es results que contiene -> 'desactivado'
               byte[] results = www.downloadHandler.data;
               depurado=int.Parse(www.downloadHandler.text);
            
               Debug.Log("DEPURADO int:"+depurado);
           }
       }
    }

}
