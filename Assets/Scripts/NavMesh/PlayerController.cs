using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour
{

    [SerializeField] private NavMeshAgent agent;
    
      
    void Update()
    {
        Ray cursorHit;
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
        
            cursorHit = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());//Calculates the ray from the screen to the current mouse position and into infinity
            Debug.DrawRay(cursorHit.origin, cursorHit.direction * 20f, Color.red, 2f);

            
            if (Physics.Raycast(cursorHit, out RaycastHit hit))
            {
                agent.SetDestination(hit.point);

            }
        }
    }

}
