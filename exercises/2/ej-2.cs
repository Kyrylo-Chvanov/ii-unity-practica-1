using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Vector3 First;
    public Vector3 Second;
    public float FirstMagnitude;
    public float SecondMagnitude;
    public float Angle;
    public float Distance;
    public Vector3 HigherVector;
    void Start()
    {
        FirstMagnitude = First.magnitude;
        Debug.Log("Magnitud del primer vector: " + FirstMagnitude);
        SecondMagnitude = Second.magnitude;
        Debug.Log("Magnitud del segundo vector: " + SecondMagnitude);
        Angle = Vector3.Angle(First, Second);
        Debug.Log("El ángulo es: " + Angle);
        Distance = Vector3.Distance(First, Second);
        Debug.Log("La distancia entre ellos es: " + Distance);
        if (Mathf.Approximately(First.y, Second.y))
        {
            HigherVector = First;
            Debug.Log("Ambos vectores están exactamente a la misma altura");
        }
        else if (First.y > Second.y)
        {
            HigherVector = First;
            Debug.Log("El primer vector está a una altura mayor que el segundo vector");
        }
        else
        {
            HigherVector = Second;
            Debug.Log("El segundo vector está a una altura mayor que el primer vector");
        }
    }

    void Update()
    {

    }
}
