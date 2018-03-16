using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour {

    /// <summary>
    /// Initialize variables
    /// </summary>
    private float enemyDamage = 0.25f; 
    private Rigidbody2D playerRidg;
    private Animator anim;
    
    [Header("Health Image")]
    public Image healthBar;

    void Awake()
    {
        playerRidg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        playerRidg.velocity = Vector2.right;
    }
	
    void OnMouseDown()
    {
        healthBar.fillAmount = 0;
        anim.SetBool("IsDead", true);
        playerRidg.velocity = Vector2.zero;
        Destroy(gameObject , 2.5f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerRidg.velocity = Vector2.zero;
            Destroy(gameObject, 1f);
        }
    }
}
