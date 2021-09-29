using UnityEngine;
using UnityEngine.UI;
using TMPro;    

public class Movement : MonoBehaviour
{
    

    [Header("Speed Settings")]
    [SerializeField]
    private float _currentSpeed;
    public float _baseSpeed;
    public float _sprintSpeed;
    public bool isSprinting = false;

    [Header("Stamina Settings")]
    public float _stamina;
    public float depleteAmount;
    public float regenAmount;
     public float regenSpeed;
    public float lastRegen;
    public float _minStamina;
    public float _maxStamina = 100f;
    public TextMeshProUGUI StaminaDisplay;
    public Image LeftStamina;
    public Image RightStamina;
    


    private void Start() 
    {
        _stamina = _maxStamina;
        _minStamina = 0f;
        depleteAmount = 50f;
        regenAmount = 0.1f;

    }
    void Update()
    {
        StaminaDisplay.text = _stamina.ToString("F0");

        //STOP STAMINA FROM INCREASING/DECREASING INFINTLEY
        if(_stamina > 100) _stamina = _maxStamina;
        if(_stamina < 0) _stamina = _minStamina;



#region Movement Input
    

        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * _currentSpeed*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * _currentSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * _currentSpeed*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _currentSpeed * Time.deltaTime;
        }

        //Sprinting and Stamina 
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) && _stamina > _minStamina)
        {   
            isSprinting = true;
            Sprinting();
            DepleteStamina();
        }
            else 
            {
                isSprinting = false; 
                _currentSpeed = _baseSpeed;
                RegenStamina();
            }
    }
#endregion

    void Sprinting()
    {
        _currentSpeed = _baseSpeed + _sprintSpeed;
        transform.position += transform.forward * _currentSpeed*Time.deltaTime;
    }

    void DepleteStamina()
    {
        _stamina -= depleteAmount * Time.deltaTime;

        if(_stamina <= 0)
        {
            isSprinting = false;
        }
    }

    void RegenStamina()
    {   // only regen if not sprinting and stmaina is less than max stamina
        if(Time.time - lastRegen > regenSpeed && !isSprinting && _stamina < _maxStamina)
        {
            _stamina += regenAmount;
            lastRegen = Time.time;
        }
    }

    // void StaminaUpdate()
    // {
    //     if(_stamina == _maxStamina)
    //     {
    //         LeftStamina.fillAmount = 1;
    //         RightStamina.fillAmount = 1;
    //     }
    // }
    
    /*  TODO
        Some sort of timer to check how many secs have passed since the player has been 
        on 0 stamina after x seconds start to regenerate stamina LOOK AT GAME MECHANICS YT PLAYLIST 2:00 */

}
