using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
