using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MeteorMovement : MonoBehaviour
{
    [SerializeField] Sprite[] meteorSprites;
    [SerializeField] private float offset = 1f;
    private Vector2 moveDirection;
    public float speed = 3f;

    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = GetRandomSpriteMeteor();
    }

    void Update()
    {
        transform.Translate(moveDirection * (speed * Time.deltaTime));
    }

    private Sprite GetRandomSpriteMeteor()
    {
        return meteorSprites[Random.Range(0, meteorSprites.Length)];
    }
    public void GetDirection()
    {
        Vector2 target = Vector2.zero;

        Vector2 dir = (target - (Vector2)transform.position).normalized;

        Vector2 randomOffset = new Vector2(Random.Range(-offset, offset), Random.Range(-offset, offset));
        moveDirection = (dir + randomOffset).normalized;
    }
    
    
}