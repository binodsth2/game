using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Bird : MonoBehaviour
{
    private const int LEFT_BUTTON = 0;
    private int _score;

    [SerializeField] private TextMeshPro _scoreText;
    [SerializeField] private float _flapForce = 8f;
    [SerializeField] private float _rotation = 1.5f;
    [SerializeField] private float _maxHeight = 4f;


    private Animator _animator;
    private Rigidbody2D _rb;



    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(LEFT_BUTTON))
        {
            Flap();
        }

        _rb.MoveRotation(_rb.velocity.y * _rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.Play("Bird_Hit");
        Time.timeScale = 0.1f;
        Invoke(nameof(ReloadScene), 0.2f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _score++;
        _scoreText.text = _score.ToString();
    }

    private void Flap()
    {
        //Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        if (transform.position.y >= _maxHeight) return;

        _rb.velocity = new Vector2(_rb.velocity.x, 0f);
        _rb.AddForce(Vector2.up*_flapForce, ForceMode2D.Impulse);
    }

    private void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
