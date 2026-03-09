using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] enemyData basicEnemyData;
    [SerializeField] private GameObject player;

    private Rigidbody2D rb;
    private float currentHealth;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        EnemySpawner.enemyActiveCounter++;
        player = GameObject.FindGameObjectWithTag("Player");
        currentHealth = basicEnemyData.LifePoints;
    }

    private void OnDisable()
    {
        EnemySpawner.enemyActiveCounter--;
        CancelInvoke();

    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (player == null) return;

        Vector2 direction = ((Vector2)player.transform.position - rb.position).normalized;
        rb.linearVelocity = direction * basicEnemyData.Speed;
    }
}
