using UnityEngine;

[CreateAssetMenu(fileName = "enemyData", menuName = "Scriptable Objects/enemyData")]
public class enemyData : ScriptableObject
{
    [SerializeField] private string enemyName;
    [SerializeField] private float damage;

    [SerializeField] private float lifePoints;
    [SerializeField] private float speed;
    [SerializeField] private bool isPossesable;

    public string EnemyName { get { return enemyName; } }
    public float Damage { get { return damage; } }
    public float Speed { get { return speed; } }
    public bool IsPossesable { get { return isPossesable; } }
    public float LifePoints { get { return lifePoints; } }
}