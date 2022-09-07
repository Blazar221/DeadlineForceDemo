using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private Player hero;
    private float moveSepeed;
    private Vector3 dirToHero;
    private Vector3 localScale;


    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        hero = FindObjectOfType(typeof(Player)) as Player;
        moveSepeed = 2f;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    private void FixedUpdate() {
        MoveEnemy();
    }

    private void MoveEnemy() {
        dirToHero = (hero.transform.position - transform.position).normalized;
        rb.velocity = new Vector2(dirToHero.x, dirToHero.y) * moveSepeed;
    }

    private void LateUpdate() {
        if(rb.velocity.x > 0) {
            transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
        }
        else if(rb.velocity.x < 0) {
            transform.localScale = new Vector3(-localScale.x, localScale.y, localScale.z);
        }
    }
}
