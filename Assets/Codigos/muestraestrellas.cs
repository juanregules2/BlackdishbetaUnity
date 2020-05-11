using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muestraestrellas : MonoBehaviour
{

    public GameObject estrellasgo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void muestraestrellasM(){
        estrellasgo.SetActive(true);
    }
    public void quitaestrellasM(){
        estrellasgo.SetActive(false);
    }
}
