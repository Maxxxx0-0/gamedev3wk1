using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData")]
public class EnemyData : ScriptableObject
{
    public Sprite shipsprite;
    public float shipSpeed;
    public int shipHp;
}
