using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

    /// <summary>
    /// Initialize variables
    /// </summary>
    [SerializeField]
    private int lives = 4;
    private int damage = 1;
    private float  healthDamage = 0.25f;

    private AudioSource explosionAudio;
    public Transform  playerExplosion;

    [Header("Health Image")]
    public Image healthBar;

    void Awake()
    {
        explosionAudio = GetComponent<AudioSource>();
    }

	/// <summary>
    /// Calls game over function
    /// </summary>
	void FixedUpdate ()
    {
        GameOver();
	}
	
	/// <summary>
    /// Checks if there is collision with the enemy
    /// </summary>
    /// <param name="other"></param>
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            lives -= damage;
            healthBar.fillAmount -= healthDamage;
            
        }
    }

    /// <summary>
    /// When the player dies explosion instantiates and the time freezes
    /// </summary>
    private void GameOver()
    {
        if (lives == 0)
        {
            DestroyObject(gameObject);
            explosionAudio.Play();
            GameObject explosion = Instantiate(playerExplosion , transform.position , transform.rotation) as GameObject;
            DestroyObject(explosion , 2f);
            Time.timeScale = 0f;
        }
    }
}
