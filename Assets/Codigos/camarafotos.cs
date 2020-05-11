using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class camarafotos : MonoBehaviour
{	public GameObject todo;
    public Text textorefleja;
	public GameObject logoBD;
	bool apagado;
    bool fototomada=false;
    bool mu=false;
	double tiempo;
	int fotos;
    string stringX="";
    string stringanterior="";
    public Image imagefoto;
    float imagefotosize=0;
    public Sprite transparentesprite;
    public Sprite camarasprite;
    public Image camaraimage;
   // public Image muestrafoto;
    public bool takingScreenshot = false;
    

    public void CaptureScreenshot()
    {
        camaraimage.sprite=transparentesprite;
        todo.SetActive(false);
        NativeGallery.Permission permission = NativeGallery.CheckPermission();
        if (permission == NativeGallery.Permission.ShouldAsk) 
        {
     permission = NativeGallery.RequestPermission();
     //Debug.Log("Asking");
        }

        /**PERMISION CAMERA ANDROID
        https://stackoverflow.com/questions/50875097/c-sharp-unity-script-to-take-and-save-screenshot-in-android-gallery-with-library
         */

        StartCoroutine(TakeScreenshotAndSave());
    }
    

	// Use this for initialization
	void Start () {

 
	}
	
	// Update is called once per frame
	void Update () {


		
	}
    public void reactiva(){
        todo.SetActive(true);
				logoBD.SetActive(false);
				tiempo=0;
				global.apagado=false;
                todo.SetActive(true);
                fototomada=false;
                imagefoto.enabled=true;
    }
	public void screenshot_m(){
		
	}
    
    
    
    
    public void capturascreenshotNativo(){
    CaptureScreenshot();
    }





   private IEnumerator TakeScreenshotAndSave()
    {

        NativeGallery.Permission permission = NativeGallery.CheckPermission();
        if (permission == NativeGallery.Permission.ShouldAsk) 
        {
     permission = NativeGallery.RequestPermission();
    
        }else{
       

        }

        takingScreenshot = true;
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();
        fotos=Random.Range(10000,99999);
        // Save the screenshot to Gallery/Photos
        string name = string.Format("foto_"+fotos+".png", Application.productName, "{0}", System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
        //Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(ss, Application.productName + " Captures", name));
        takingScreenshot = false;
        
        string stringX="Permission result: " + NativeGallery.SaveImageToGallery(ss, Application.productName + " Captures", name);
        //textorefleja.text+=stringX;

        todo.SetActive(true);
        camaraimage.sprite=camarasprite;
    }
    
}
