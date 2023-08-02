using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tartaruga : MonoBehaviour
{

    public float velocidadeDaTartaruga  ;
    public float entradaHorizontal;
    public float entradaVertical;


    // Start is called before the first frame update
    void Start()
    {
        
        velocidadeDaTartaruga = 3.0f;
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
   Movimento();

      
    }


 private void Movimento(){

        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * velocidadeDaTartaruga * Time.deltaTime * entradaHorizontal );

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * velocidadeDaTartaruga * Time.deltaTime * entradaVertical );

        if ( transform.position.y > 3.5f ) {
            transform.position = new Vector3(transform.position.x,3.5f,0);
        }

        if ( transform.position.y < -3.8f){
            transform.position = new Vector3(transform.position.x,-3.8f,0);
        }

        if ( transform.position.x > 9.65f){
            transform.position = new Vector3(-9.65f,transform.position.y,0);
        }

         if ( transform.position.x < -9.65f){
            transform.position = new Vector3(9.65f,transform.position.y,0);
        } 

    }


}




    