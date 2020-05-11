using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagesprite : MonoBehaviour
{


    public Image image;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite.sprite=image.sprite;
        //dfsdf
        /*
        UPDATE:
        si pongo un sprite y un image, recoge el tamaño del image, pero por alguna razon cuando agarro el tamaño de la pizza 
        desde internet lo pone miniatura, no estoy seguro como hacerlo mas grande
        ya intente poner el mismo sprite e image en el mismo gameobject, y funcionan pero si lo jala
        de internet se vuelve a hacer pequeño
        
        
        
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
