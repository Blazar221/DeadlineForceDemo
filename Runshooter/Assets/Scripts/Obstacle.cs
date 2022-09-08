using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField]
    private float movingSpeed = 0.03f;

    private Vector3 prevPosition;

    // Start is called before the first frame update
    void Start()
    {
        prevPosition = transform.position;
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        Vector3 curPosition = new Vector3(prevPosition.x, prevPosition.y - movingSpeed);
        transform.position = curPosition;
        prevPosition = curPosition;
    }
}
