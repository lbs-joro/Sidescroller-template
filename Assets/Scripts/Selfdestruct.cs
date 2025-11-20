using UnityEngine;

public class Selfdestruct : MonoBehaviour
{
    [SerializeField] float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, time);
    }
}
