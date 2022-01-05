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
        //STOP STAMINA FROM INCREASING/DECREASING INFINITELY
        if(_stamina > 100) _stamina = _maxStamina;
        if(_stamina < 0) _stamina = _minStamina;

        

#region Movement

        if (DialogueManager.instance.dialogueIsPlaying)
        {
            _currentSpeed = 0f;
            isSprinting = false;
            
        }

        if(CustomPlayerInputManager.instance.wPressed)
        {
            transform.position += transform.forward * (_currentSpeed * Time.deltaTime);
        }

        if(CustomPlayerInputManager.instance.aPressed)
        {
            transform.position += -transform.right * (_currentSpeed * Time.deltaTime);
        }

        if(CustomPlayerInputManager.instance.sPressed)
        {
            transform.position += -transform.forward * (_currentSpeed * Time.deltaTime);
        }

        if(CustomPlayerInputManager.instance.dPressed)
        {
            transform.position += transform.right * (_currentSpeed * Time.deltaTime);
        }

        //Sprinting and Stamina 
        if(CustomPlayerInputManager.instance.leftShiftPressed && CustomPlayerInputManager.instance.wPressed && _stamina > _minStamina && !DialogueManager.instance.dialogueIsPlaying)
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
        //sets current speed depending on whether condition is true or not
        _currentSpeed = isSprinting ? _sprintSpeed : _baseSpeed;
        
        transform.position += transform.forward * (_currentSpeed * Time.deltaTime);
    }

    void DepleteStamina()
    {
        // subtract stamina from a specified value
        _stamina -= depleteAmount * Time.deltaTime;
        
        //set isSprinting false
        if(_stamina <= 0)
        {
            isSprinting = false;
        }
    }

    void RegenStamina()
    {   
        //check if left shit is pressed and current stamina is less than our max THEN it starts to regenerate
        if(Time.time - lastRegen > regenSpeed && !CustomPlayerInputManager.instance.leftShiftPressed && _stamina < _maxStamina)
        {
            _stamina += regenAmount;
            lastRegen = Time.time;
        }
    }

   

}
