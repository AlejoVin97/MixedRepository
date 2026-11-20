using UnityEngine;

public abstract class Enemigo : MonoBehaviour
{
    [SerializeField] protected string nombre = "Enemigo";
    [SerializeField] protected int danio = 10;


    public virtual void Atacar(Jugador objetivo)
    {
        Avanzar(objetivo, 0.5f);
        Debug.Log(nombre + " ataca: " +  danio);
        objetivo.RecibirDanio(danio);

    }
    protected void Avanzar(Jugador objetivo, float paso )
    {
        Vector3 destino = objetivo.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, destino, paso);
    }
}
