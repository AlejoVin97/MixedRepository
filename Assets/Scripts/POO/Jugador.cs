using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour
{
    [SerializeField] private int vidaMaxima = 100;
    private int vida;
    public int m_Vida { get { return vida; } }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { vida = vidaMaxima; }

    public void RecibirDanio(int cantidad)
    {
        if (cantidad <= 0) return;
        vida = Mathf.Max(vida - cantidad, 0);
        Debug.Log("Jugador: vida " + vida);
        if (vida == 0) gameObject.SetActive(false);

    }

    public void Curar(int cantidad)
    {
        if (cantidad <= 0) return;
        vida = Mathf.Min(vida + cantidad, vidaMaxima);
        Debug.Log("Jugador: vida " + vida);

    }

}
