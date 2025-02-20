using UnityEngine;

public class VerJugador : MonoBehaviour
{
    public Transform objetivo;
    public float rangoVision = 50;
    public float rangoFOV = 30;
    private Vector3 jugadorDesdeIA;
    private float distanciaAJugador = 0;
    public float angulo = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool visto = false;
        distanciaAJugador = Vector3.SqrMagnitude(transform.position - objetivo.position);
        if (distanciaAJugador <= (rangoVision * rangoVision))
        {
            jugadorDesdeIA = objetivo.position - transform.position;
            angulo = Vector3.Angle(transform.forward, jugadorDesdeIA);
            if (angulo <= rangoFOV)
            {
                visto = true;
            }
        }
        if (visto)
        {
            Debug.Log("Veo jugador");
        }
        else
        {
            Debug.Log("No veo jugador");
        }
    }
}