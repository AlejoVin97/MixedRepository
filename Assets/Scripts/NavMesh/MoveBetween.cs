using UnityEngine;

public class MoveBetween : MonoBehaviour
{
    [SerializeField] private GameObject point1;
    [SerializeField] private GameObject point2;
    [SerializeField] private float speed = 0.4f;
    private Vector3 nextPoint;
    private Vector3 currentPos;
    private bool isNextPoint1 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextPoint = point1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = transform.position;
        if (currentPos == nextPoint)
        {
            selectNext();
        }
        else
        {
            transform.position = Vector3.MoveTowards(currentPos, nextPoint, speed*Time.deltaTime);
        }
    }

    void selectNext()
    {
        if (isNextPoint1)
        {
            nextPoint = point1.transform.position;
            isNextPoint1 =false;
        }
        else
        {
            nextPoint = point2.transform.position;
            isNextPoint1 = true;
        }
    }
}
