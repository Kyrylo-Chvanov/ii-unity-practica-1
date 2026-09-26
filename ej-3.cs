using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public Text text;
    void Start()
    {
    }

    void Update()
    {
        text.text = $"{transform.position}";
    }
}
