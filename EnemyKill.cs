using UnityEngine;
using System.Collections;

public class EnemyKill : MonoBehaviour {

    private GameObject enemy;
    
    public void KillEnemy()
    {
        if (enemy.tag == "Enemy")
        {
            Debug.Log("Enemy");
        }
    }
	
}
