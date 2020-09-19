using UnityEngine;

public class BoruHareketi : MonoBehaviour
{
    public float hiz = 2;

    private void Start()
    {
        Destroy(gameObject, 6);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
    }
}
