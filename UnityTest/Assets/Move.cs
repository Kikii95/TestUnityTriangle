using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        float rotationY = 0;

        if(Input.GetKey(KeyCode.W))
        {
            move.z += Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move.z -= Speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            move.y += Speed;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            move.y -= Speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            move.x += Speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.x -= Speed;
        }

        if (Input.GetKey(KeyCode.E))
        {
            rotationY += RotationSpeed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotationY -= RotationSpeed;
        }

        transform.Rotate(Vector3.up, rotationY);
        transform.position += move * Time.deltaTime;
    }
}
