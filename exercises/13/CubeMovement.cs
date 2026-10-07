using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5;
    public float angleSpeed = 60;
    void Start()
    {

    }

    void Update()
    {
        float rotationDirection = Input.GetAxis("Horizontal");
        transform.Rotate(transform.up, rotationDirection * angleSpeed * Time.deltaTime);
        float forward = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.forward;
        transform.Translate(moveDirection * movementSpeed * forward * Time.deltaTime, Space.World);
        Debug.DrawRay(transform.position, moveDirection);
    }
}
