using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad=15;
    public float velAngular=60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0,-velAngular*Time.deltaTime,0));
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0,velAngular*Time.deltaTime,0));
        }
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(new Vector3(0,0,velocidad*Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(new Vector3(0,0,-velocidad*Time.deltaTime));
        }
    }
}
