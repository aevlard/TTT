using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private PlayerStats playerStats;

    private void Awake()
    {
        playerStats = GetComponent<PlayerStats>();
    }

    public void PerformUpMovement()
    {
        Vector2 direction = Vector2.up;
        transform.Translate(direction * playerStats.Speed * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    public void PerformDownMovement()
    {
        Vector2 direction = Vector2.down;
        transform.Translate(direction * playerStats.Speed * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.Euler(0f, 0f, 180f);
    }

    public void PerformLeftMovement()
    {
        Vector2 direction = Vector2.left;
        transform.Translate(direction * playerStats.Speed * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.Euler(0f, 0f, 90);
    }

    public void PerformRightMovement()
    {
        Vector2 direction = Vector2.right;
        transform.Translate(direction * playerStats.Speed * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.Euler(0f, 0f, -90);
    }

}
