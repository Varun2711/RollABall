using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2.0f;

    public void MoveBall(Vector3 input)
    {
        Vector3 inputXZPlane = new(input.x, input.y, input.z);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
