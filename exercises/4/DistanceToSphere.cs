using UnityEngine;

public class DistanceToSphere : MonoBehaviour
{
    public float distance;
    void Start()
    {
        GameObject esfera = GameObject.FindWithTag("Esfera");
        distance = Vector3.Distance(esfera.transform.position, transform.position);
    }

    void Update()
    {

    }
}
