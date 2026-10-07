using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public GameObject sphere;
    void Start()
    {

    }

    void Update()
    {
        Vector3 moveDirection = new(Input.GetAxis("Debug Horizontal"), 0, Input.GetAxis("Debug Vertical"));
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime);
        transform.LookAt(sphere.transform);
    }
}
