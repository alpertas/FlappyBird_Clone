using UnityEngine;

public class Bird : MonoBehaviour
{
    //Kuş hareketi
    public Rigidbody2D rb2d;
    public float v=3f;

    public bool isDead;

    public GameManager gm;

    public GameObject DeathScreen;
    //Kanat Çırpma Efekti
    public AudioSource efekt;
    //Ölüm Efekti
    public AudioSource hit;
    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        bird();
    }

    void bird()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * v;
            efekt.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "skorAlani")
        {
            gm.SkorGuncelle();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
            hit.Play();
        }
    }
}
