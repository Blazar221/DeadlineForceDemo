using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float heroSpeed;
    private Rigidbody2D heroRb;
    private Vector2 heroDir;

    [SerializeField]
    private float halfWidth = 7.3f;
    [SerializeField]
    private float halfHeight = 4.5f;

    // Start is called before the first frame update
    void Start() {
        heroRb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update() {
        float dirX = Input.GetAxisRaw("Horizontal"), dirY = Input.GetAxisRaw("Vertical");
        heroDir = new Vector2(dirX, dirY).normalized;
    }

    void FixedUpdate() {
        heroRb.velocity = new Vector2(heroDir.x * heroSpeed, heroDir.y * heroSpeed);
    }

    private void LateUpdate() {
        Vector3 curPosition = transform.position;
        curPosition.x = Mathf.Clamp(curPosition.x, -halfWidth, halfWidth);
        curPosition.y = Mathf.Clamp(curPosition.y, -halfHeight, halfHeight);
        transform.position = curPosition;
    }
}
