using UnityEngine;

public class Levels : MonoBehaviour
{
    public GameObject plataformaPrefab;
    public int cantidadPlataformas = 10;
    public float distancia = 15f;

    void Start()
    {
        GenerarNiveles();
    }

    void GenerarNiveles()
    {
        for (int i = 0; i < cantidadPlataformas; i++)
        {
            Vector3 posicion = new Vector3(
                Random.Range(-5f, 5f),
                0,
                i * distancia
            );

            Instantiate(plataformaPrefab, posicion, Quaternion.identity);
        }
    }
}