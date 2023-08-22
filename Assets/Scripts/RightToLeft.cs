using UnityEngine;

public class RightToLeftMovement : MonoBehaviour
{
    public float movingDistance = 2f; //controls how far the object moves
    public float movingSpeed = 2f; //controls the speed of the object
    public Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new position based on PingPong movement
        //The Mathf.PingPong function creates a smooth back-and-forth movement
        float newPositionX = initialPosition.x - Mathf.PingPong(Time.time * movingSpeed, movingDistance);
        Vector3 newPosition = new Vector3(newPositionX, transform.position.y, transform.position.z);


        // Update the object's position
        transform.position = newPosition;
    }
}
