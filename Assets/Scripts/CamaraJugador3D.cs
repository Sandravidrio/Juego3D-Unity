using UnityEngine;

public class CamaraJugador3D : MonoBehaviour
{
    public Transform jugador;
    public Vector3 distancia = new Vector3(0, 5, -7);

    void LateUpdate()
    {
        transform.position = new Vector3(
            jugador.position.x + distancia.x,
            distancia.y,
            jugador.position.z + distancia.z
        );
    }
}