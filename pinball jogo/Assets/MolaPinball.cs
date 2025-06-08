using UnityEngine;

public class MolaPinball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadeCompressao = 5f;
    public float forcaExtra = 300f;
    private bool comprimindo = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            comprimindo = true;
            rb.linearVelocity = Vector2.down * velocidadeCompressao;
        }
        else if (comprimindo && Input.GetKeyUp(KeyCode.DownArrow))
        {
            comprimindo = false;
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(Vector2.up * forcaExtra, ForceMode2D.Impulse);
        }
    }
}
