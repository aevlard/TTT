using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float speed;

    public float Speed
    {
        get => speed;
        set => speed = value;
    }
}
