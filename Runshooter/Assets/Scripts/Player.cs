using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float heroSpeed;
    private Rigidbody2D heroRb;
    private Vector2 heroDir;

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
}
