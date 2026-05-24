using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float aumento = 0.1f;

    void Update()
    {
        float moverX = Input.GetAxis("Horizontal");
        float moverZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moverX, 0, moverZ);

        velocidad += aumento * Time.deltaTime;

        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}