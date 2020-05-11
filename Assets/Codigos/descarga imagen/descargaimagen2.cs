using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class descargaimagen2 : MonoBehaviour
{

    public Image img;
    public Image imagenmuestra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Q)){
            descargaimagenVoid("dfdfdf");
        }
        
    }
    void descargaimagenVoid(string ligaurl){
        Debug.Log("***descargaimagen28:"+ligaurl);
        Debug.Log("tratare de descargar:"+ligaurl);
        //Debug.Log("img:"+imagendondeserefleja);
        // StartCoroutine(setImage(ligaurl));
        //ligaurl="https://blackdish.mx/blackdish-beta-v3/backend/model/img_admin/WhatsApp_Image_2020-03-19_at_21-removebg-preview.png";
        StartCoroutine(setImage(ligaurl));
        //imagendondeserefleja.sprite=spritex;
        

    }
    IEnumerator setImage(string url) {

        Sprite spritex;
         Debug.Log("entro a set image");
       Texture2D texture;

    //UNITY WEB REQUEST
    Debug.Log("url dada:"+url);
    Debug.Log("url ajustada:https://blackdish.mx/blackdish-beta-v3/backend/model/img_admin/WhatsApp_Image_2020-03-19_at_21-removebg-preview.png");
    url="https://blackdish.mx/blackdish-beta-v3/backend/model/img_admin/WhatsApp_Image_2020-03-19_at_21-removebg-preview.png";
      UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.Send();

        if(www.isNetworkError) {
            Debug.Log(www.error);
            Debug.Log("hubo pedos");
            
        }
        else {
            texture = ((DownloadHandlerTexture)www.downloadHandler).texture;


            Vector2 v=new Vector2(texture.width,texture.height);
              Rect rect=new Rect(0,0,texture.width,texture.height);
   
                  spritex=Sprite.Create(texture,rect,v);
                
                 img.sprite=spritex;
                 Debug.Log("ya coloque la imagen");
                 
        }//else





    // calling this function with StartCoroutine solves the problem
    
    
            }//set image





    public void muestraPlatillo4(){
		Debug.Log("muestraplatillo3");
			
				imagenmuestra.sprite=img.sprite;
			}//muestraplatillo4


		}//clase propiedades_platillos_2

	

