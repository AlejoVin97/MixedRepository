using UnityEngine;

public abstract class Enemigo : MonoBehaviour
{
    [SerializeField] protected string nombre = "Enemigo";
    [SerializeField] protected int danio = 10;


    public abstract void Atacar(Jugador objetivo);
    
    protected void Avanzar(Jugador objetivo, float paso )
    {
        Vector3 destino = objetivo.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, destino, paso);
    }
}
