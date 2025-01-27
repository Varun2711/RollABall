using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2.0f;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; // intialize our input vector
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; // "a += b" <=> "a = a + b"
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }

        Debug.Log("Resultant Vector: " + inputVector);

        Vector3 inputXZPlane = new(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
