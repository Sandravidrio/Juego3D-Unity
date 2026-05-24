using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 8f;
    public float aumento = 0.2f;

    void Update()
    {
        float moverX = Input.GetAxis("Horizontal");
        float moverZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moverX, 0, moverZ);

        velocidad += aumento * Time.deltaTime;

        transform.Translate(movimiento * velocidad * Time.deltaTime);

        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}