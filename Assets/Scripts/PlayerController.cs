using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 2f;
    private Rigidbody _playerRB;


    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float _verticalInput = Input.GetAxis("Vertical");
        float _horizontalInput = Input.GetAxis("Horizontal");

        _playerRB.AddForce(_speed * _verticalInput * Vector3.forward);
        _playerRB.AddForce(_speed * _horizontalInput * Vector3.right);
    }
}
