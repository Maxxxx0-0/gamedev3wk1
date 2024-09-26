using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmemyVisual : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    //ref to enemydata
    public EnemyData enemyData;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // to set sprite
        spriteRenderer.sprite = enemyData.shipsprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
