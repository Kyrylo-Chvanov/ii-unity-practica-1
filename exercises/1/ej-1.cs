using UnityEngine;

public class Cube : MonoBehaviour
{
    public uint frameInterval = 120;
    public uint positionRange = 10;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = randomColor();
    }

    void Update()
    {
        if (frameCounter < frameInterval)
        {
            frameCounter++;
        }
        else
        {
            frameCounter = 0;
            renderer.material.color = randomColor();
            transform.position = randomPosition();
        }
    }
    private uint frameCounter = 0;
    private Renderer renderer;
    private Color randomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }

    private Vector3 randomPosition()
    {
        return new Vector3(
            Random.Range(-positionRange, positionRange),
            Random.Range(-positionRange, positionRange),
            Random.Range(-positionRange, positionRange)
      );
    }
}
