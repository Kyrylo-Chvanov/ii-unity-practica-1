using UnityEngine;

public class Sphere : MonoBehaviour
{
    public DistanceToSphere CubeDistanceToSphere;
    public DistanceToSphere CylinderDistanceToSphere;
    void Start()
    {
        Debug.Log($"Cube distance to sphere {CubeDistanceToSphere.distance}");
        Debug.Log($"Cylinder distance to sphere {CylinderDistanceToSphere.distance}");
    }

    void Update()
    {
    }
}
