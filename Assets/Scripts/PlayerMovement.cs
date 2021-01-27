using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 30f;
    private readonly float leftBoundry = -21.0f;
    private readonly float rightBoundry = 21.0f;
    private readonly float topBoundry = 80.0f;
    private readonly float bottomBoundry = -65.0f;
    private readonly float speedReseter = 0.0001f;

    public GameObject bullets;
    
    void Start()
    {
        
    }

    void Update()
    {
        BoundryChecker();
        Movement();
        ShootBullets();
    }

    void BoundryChecker() {
        if (transform.position.x < leftBoundry) {
            transform.position = new Vector3(leftBoundry, transform.position.y, transform.position.z);
            speed = speedReseter;
        } else if (transform.position.x > rightBoundry) {
            transform.position = new Vector3(rightBoundry, transform.position.y, transform.position.z);
            speed = speedReseter;
        } else if (transform.position.z > topBoundry) {
            transform.position = new Vector3(transform.position.x, transform.position.y, topBoundry);
            speed = speedReseter;
        } else if (transform.position.z < bottomBoundry) {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottomBoundry);
            speed = speedReseter;
        } else {
            speed = 30f;
        }
    }

    void Movement() {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }

    void ShootBullets() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bullets, transform.position, bullets.transform.rotation);
        }
    }
}
