
using UnityEngine;
using System.Collections;
 using UnityEngine.SceneManagement;

namespace SimpleHealthBar_SpaceshipExample
{
	public class PlayerHealth : MonoBehaviour
	{
		static PlayerHealth instance;
		public static PlayerHealth Instance { get { return instance; } }
		bool canTakeDamage = false;
		public int maxHealth = 100;
		float currentHealth = 0;
		public float time = 2.0f;
		public float invulnerabilityTime = 0.5f;

		public GameObject explosionParticles;

		public SimpleHealthBar healthBar;

	
		void Awake (){instance = GetComponent<PlayerHealth>();}

		void Start (){
			currentHealth = maxHealth;
			healthBar.UpdateBar( currentHealth, maxHealth );
		}

		void Update (){
			if(canTakeDamage){
				GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider>().enabled = false;
				time -= Time.deltaTime;
				if(time <=0){
					GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider>().enabled = true;
					time = 2.0f;
				}
			}
		}

		public void HealPlayer ()
		{
			currentHealth += ( maxHealth );

			// If the current health is greater than max, then set it to max.
			if( currentHealth > maxHealth )
				currentHealth = maxHealth;

			// Update the Simple Health Bar with the new Health values.
			healthBar.UpdateBar( currentHealth, maxHealth );
		}

		public void TakeDamage ( float damage )
		{
				currentHealth -= damage;

			if( currentHealth <= 0 )
			{   canTakeDamage = true;
				currentHealth = 0;
				Death();
			}
			healthBar.UpdateBar( currentHealth, maxHealth );

		}

		public void Death ()
		{
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		}

		void OnTriggerEnter(Collider col){
				if(col.gameObject.tag == "enemy"){

					TakeDamage(5);
				}
		}
	}
}