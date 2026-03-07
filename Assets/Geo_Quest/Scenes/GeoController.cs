using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    int var = 3;
    string valueOne = "Hello";
    Rigidbody2D rb;
    public int speed = 5;
    public string nextlevel = "level 2";
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string valueOne = "World";
        sr = GetComponent<SpriteRenderer>();

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        // Debug.Log(xInput);
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sr.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sr.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.color = Color.blue;
        }


        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                 
                    SceneManager.LoadScene(nextlevel);
                    break;
                }

            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
        }


    }
}
      




    /*  if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
    }
    private Rigidbody2D rb;
    */