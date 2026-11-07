using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{
   
    public MeshRenderer Renderer;
    //define los componentesdel color
    public int color_r, color_g, color_b = 0;
    //define la opacidad del color
    public float color_opacity = 0.0f;
    //Recibe entrada para realizar el movimiento
    public InputAction spazzmingAction;
    //
    public int nextPosition = 0;

    //Lista de posiciones a las cuales mover el cubo
    Vector3[] positions = {new Vector3( 1.0f, 1.0f, 0.0f),
                           new Vector3( 0.0f, 1.0f, 1.0f),
                           new Vector3( 1.0f,-1.0f, 0.0f), 
                           new Vector3(-1.0f, 1.0f, 0.0f), 
                           new Vector3(-1.0f,-1.0f, 0.0f), 
                           new Vector3( 0.0f, 1.0f,-1.0f),
                           new Vector3( 1.0f, 1.0f, 0.0f),
                           new Vector3( 1.0f, 0.0f,-1.0f),
                           new Vector3(-1.0f, 0.0f, 1.0f)}; 

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        //Inicializa los colores a utilizar en tiempo de ejecucion (valores de rojo, verde y azul para el color, asi como la opacidad del objeto)
        color_r = 252;
        color_g = 186;
        color_b = 3;
        color_opacity = 0.8f;
        //se crea un Vector3 con la conversión del valor RBG de entero a porcentual
        Vector3 rgb = (new Vector3(color_r, color_g,color_b) )/255f;
        //se genera una referencia al material del objeto (en este caso, el cubo) para...
        Material material = Renderer.material;
        //...modificarle el color al material, con los valores especificados
        material.color = new Color(rgb[0], rgb[1], rgb[2], color_opacity);
        spazzmingAction.Enable(); 
    }

    //En cada frame, rota 10° por segundo, y si se presiona la tecla z se mueve el cubo (con base en una posicion definida de antemano) el doble de la distancia dada por la posicion actual en el arreglo "position"
    void Update()
    {   
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f, Space.World);

        if (spazzmingAction.triggered)
        {   
            transform.Rotate(0.0f, 0.0f, 45.0f,Space.World);
            MoveInPositions();
        }
    }

    void MoveInPositions()
    {
        transform.position = new Vector3(3, 4, 1) + (positions[nextPosition] * 2);

        nextPosition += 1;

        if (nextPosition == positions.Length)
        {
            nextPosition = 0;
        }
    }


}
