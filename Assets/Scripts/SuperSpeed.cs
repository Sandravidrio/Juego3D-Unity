using UnityEngine;
using System.Collections;

public class SuperSpeed : MonoBehaviour
{
    public MovimientoJugador jugador;
    public float velocidadNormal = 5f;
    public float velocidadRapida = 12f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(AumentarVelocidad());
            gameObject.SetActive(false);
        }
    }

    IEnumerator AumentarVelocidad()
    {
        jugador.velocidad = velocidadRapida;

        yield return new WaitForSeconds(3);

        jugador.velocidad = velocidadNormal;
    }
}