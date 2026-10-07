using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    public GameObject sphere;
    void Start()
    {

    }

    void Update()
    {
        Vector3 moveDirection = sphere.transform.position - transform.position;
        moveDirection.y = 0;
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
