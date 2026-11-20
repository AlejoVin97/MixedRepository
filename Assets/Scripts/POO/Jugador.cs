using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour
{
    [SerializeField] private int vidaMaxima = 100;
    private int vida;
    public int Vida { get { return vida; } }
    private Vector2 lookKiller;
    [SerializeField] private GameObject Enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { vida = vidaMaxima; }

    void Update()
    {
        lookKiller = (Enemy.transform.position - transform.position).normalized;
        transform.up = lookKiller.normalized;
    }

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
        vida = Mathf.Min(vida + cantidad, Vida);
        Debug.Log("Jugador: vida " + vida);

    }

}
