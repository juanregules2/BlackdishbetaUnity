
/*

USELESS
todo migrado a propiedades_platillos_2.cs

 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;
public class descargaimagen : MonoBehaviour
{
    //public Image profileImage;
   
    SpriteRenderer spriteRenderr;
    Sprite spritex;
    //public Image imagex=new Image();
    
   //  C:\Users\Norman\OneDrive\Documentos\rutadatosprueba.html

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void descargaimagenM( string ligaurl){
        //Debug.Log("***descargaimagen28:"+ligaurl);
        Debug.Log("tratare de descargar:"+ligaurl);
        //Debug.Log("img:"+imagendondeserefleja);
        // StartCoroutine(setImage(ligaurl));
        ligaurl="https://blackdish.mx/blackdish-beta-v3/backend/model/img_admin/WhatsApp_Image_2020-03-19_at_21-removebg-preview.png";
        StartCoroutine(setImage(ligaurl));
        //imagendondeserefleja.sprite=spritex;
       // return imagex;

    }
    IEnumerator setImage(string url) {

        
         Debug.Log("entro a set image");
       Texture2D texture;

    //UNITY WEB REQUEST
      UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.Send();

        if(www.isNetworkError) {
            Debug.Log(www.error);
            
        }
        else {
            texture = ((DownloadHandlerTexture)www.downloadHandler).texture;


            Vector2 v=new Vector2(texture.width,texture.height);
              Rect rect=new Rect(0,0,texture.width,texture.height);
   
                  spritex=Sprite.Create(texture,rect,v);
                
                
                 //imagex.sprite=spritex;

                 //ya meti este codigo en propiedades_platillos_2.cs
        }





    // calling this function with StartCoroutine solves the problem
    
    
}

}
