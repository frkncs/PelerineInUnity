using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables

    // Public Variables

    // Private Variables
    private float horInput, vertInput;

    private const float _moveSpeed = 8f;
    private const float _rotateSpeed = .5f;

    #endregion Variables

    private void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horInput, 0, vertInput) * (Time.deltaTime * _moveSpeed));

        if (horInput > 0)
        {
            transform.Rotate(Vector3.up * 360 * (Time.deltaTime * _rotateSpeed));
        }
        
        if (horInput < 0)
        {
            transform.Rotate(-Vector3.up * 360 * (Time.deltaTime * _rotateSpeed));
        }
    }
}