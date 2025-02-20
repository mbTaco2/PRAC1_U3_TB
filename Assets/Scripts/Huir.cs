using UnityEngine;

public class Huir : MonoBehaviour
{
    public float velocidad=5;
    public Transform objetivo;
    private float x=0;
    private float y=0;

    private float z=0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        y=transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        x=transform.position.x;
        z=transform.position.z;
        if(objetivo.position.x>x){
            x-=velocidad*Time.deltaTime;
        }
        if(objetivo.position.x<x){
            x+=velocidad*Time.deltaTime;
        }
        if(objetivo.position.z>z){
            z-=velocidad*Time.deltaTime;
        }
        if(objetivo.position.z>z){
            z+=velocidad*Time.deltaTime;
        }

        transform.position=new Vector3(x,y,z);
    }
}
