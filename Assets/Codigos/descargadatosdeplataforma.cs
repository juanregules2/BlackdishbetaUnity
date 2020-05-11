using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class descargadatosdeplataforma : MonoBehaviour
{
    public static bool terminodedescargarbool;
    public Transform t;
    string superstring="";
    void Start() {
        terminodedescargarbool=false;
  
      

        StartCoroutine(GetText());
    }
 
    IEnumerator GetText() {

        //real USAR ESTE CUANDO FUNCIONE
        //UnityWebRequest www = UnityWebRequest.Get("https://blackdish.mx/blackdish-beta-v3/api/platillosApi.php");
        //pruebas
        UnityWebRequest www = UnityWebRequest.Get("https://raw.githubusercontent.com/juanregules2/notas/master/pruebas%20api");
        
        
        yield return www.Send();
 
        if(www.isNetworkError) {
            //Debug.Log(www.error);
        }
        else {
            // Show results as text
            Debug.Log(www.downloadHandler.text);
            superstring=www.downloadHandler.text;
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
          //  Debug.Log("result:"+superstring);
            separastring(superstring);
        }

    }

  
    void separastring(string superstring){
        clase_platillos clase_platillos=new clase_platillos();
                string idstr="";
                string nombre="";
                string descripcion="";
                string costo="";
                string imagen="";
                //Debug.Log("lista:"+global_variables.lista.Count);
                for(int i=0;i<=superstring.Length-1;i++){
                    if(superstring[i]=='"'){

                        if(superstring[i+1]=='i'||superstring[i+1]=='n'||superstring[i+1]=='d'||superstring[i+1]=='c')
                        {//if
                      //  Debug.Log("HORA DE AGREGAR");
                        string title=""+superstring[i+1]+superstring[i+2]+superstring[i+3];

                        switch (title)
                        {
                            case "idP":
                            for(int i2=i+14;i2<=superstring.Length-1;i2++){
                                if(superstring[i2]!='"'){
                                    idstr+=superstring[i2];
                                }else{i2=superstring.Length;
                               
                              }
                            }
                             //Debug.Log("idp:"+idstr);
                            clase_platillos.Id=idstr;
                            idstr="";
                            break; //idPlatillo7
                            //"idPlatillo":"11"
                            case "nom":
                             for(int i2=i+10;i2<=superstring.Length-1;i2++){
                                if(superstring[i2]!='"'){
                                    nombre+=superstring[i2];
                                }else{i2=superstring.Length;
                               
                               }
                            }
                            // Debug.Log("nombre:"+nombre);
                             clase_platillos.Nombre=nombre;
                            
                            
                            break;//nombre
                            case "des":
                            for(int i2=i+15;i2<=superstring.Length-1;i2++){
                                if(superstring[i2]!='"'){
                                    descripcion+=superstring[i2];
                                }else{i2=superstring.Length;
                             //   Debug.Log("descripcion:"+descripcion);
                             }
                            }
                            clase_platillos.Descripcion=descripcion;
                            
                            
                            break;//descripcion



                            case "cos":
                               
                            for(int i2=i+9;i2<=superstring.Length-1;i2++){
                                if(superstring[i2]!='"'){
                                    costo+=superstring[i2];
                                }else{i2=superstring.Length;
                               // Debug.Log("costo:"+costo);
                              }
                            }
                            clase_platillos.Precio=costo;
                            
                            
                            
                            break;//costo


                            case "ima":
                            for(int i2=i+19;i2<=superstring.Length-1;i2++){
                                if(superstring[i2]!='"'){
                                    if(superstring[i2]=='/'){
                                        string gg=imagen;
                                       // Debug.Log("X1imagen:"+imagen);
                                        imagen="";
                                        for(int z=0;z<=gg.Length-2;z++){
                                                imagen+=gg[z];
                                        }
                                      //  Debug.Log("X2imagen:"+imagen);
                                        
                                    }
                                    /*
                                    tratare de descargar:https:\/\/blackdish.mx\/blackdish-beta-v3\/backend\/model\/img_admin\/WhatsApp_Image_2020-03-19_at_21-removebg-preview.png
                                     */
                                    imagen+=superstring[i2];
                                }else{i2=superstring.Length;
                                //Debug.Log("imagen:"+imagen);
                              }
                            }
                            clase_platillos.Imagen=imagen;
                            Debug.Log("por agregar:"+clase_platillos.Nombre+";"+clase_platillos.Id+";"+clase_platillos.Descripcion);
                            global_variables.lista.Add(clase_platillos);
                           // Debug.Log("agregado");

                            //borra datos
                              idstr="";
                             nombre="";
                                 descripcion="";
                                 costo="";
                                imagen="";


                            break;//imagen
                            default:break;
                        }//switch case
                       
                       // LA VARIABLE "nombre" si guarda algo, pero quiero ver si se guarda en clase_platillos.Nombre
            
     
                        }//if(superstring[i+1]=='i'||superstring[i+1]=='n'||superstring[i+1]=='d'||superstring[i+1]=='c')
                        



                    }
                   
                    if(i==superstring.Length-1){

                           
                global_variables.descargaterminada=true;
                
                   
                    }
                }//termina el for
                
    }
}
