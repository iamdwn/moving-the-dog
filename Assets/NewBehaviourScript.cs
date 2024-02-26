
using UnityEngine;

public class NewBeHaviourScript : MonoBehaviour
{
    public int speed = 6;
    public Animator anim;
    public bool _isAllowedMove;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) && !anim.GetBool("attack"))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9f, 8f), transform.position.y, 0);
            transform.Translate(Vector3.left * (-speed) * Time.deltaTime);
            anim.SetBool("walk_idle", true);
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if (Input.GetKey(KeyCode.D) && !anim.GetBool("attack"))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9f, 8f), transform.position.y, 0);
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            anim.SetBool("walk_idle", true);
            transform.eulerAngles = new Vector2(0, 360);

        }
        else if (Input.GetKey(KeyCode.S) && !anim.GetBool("attack"))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.9f, -2.5f), 0);
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            anim.SetBool("walk_idle", true);
        }
        else if (Input.GetKey(KeyCode.W) && !anim.GetBool("attack"))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.9f, -2.5f), 0);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            anim.SetBool("walk_idle", true);
        }
        else
        {
            anim.SetBool("walk_idle", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y);
            anim.SetTrigger("attack");
        }
    }
}