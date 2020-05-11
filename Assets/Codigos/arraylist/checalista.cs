using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checalista : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checalistaM(ArrayList arr){
          
        Debug.Log("io:"+global_variables.io);
         clase_platillos cpp=(clase_platillos)global_variables.lista[0];
                            Debug.Log("cl:"+cpp.Nombre);
        //Debug.Log("**url:"+url+",id:"+id);
        foreach (clase_platillos platillo in global_variables.lista)
        {
            Debug.Log("2_///"+platillo.Id+","+platillo.Nombre+","+platillo.Imagen+"///");
           
        }
    }
}
