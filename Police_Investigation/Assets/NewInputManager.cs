using UnityEngine;


public class NewInputManager : MonoBehaviour
{
    public static NewInputManager instance;
    public PlayerInput playerInput;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        playerInput.Enable();
        EventManager.DisableMovement += EventManagerOnDisableMovement;
        EventManager.EnableMovement += EventManagerOnEnableMovement;
    }
    private void OnDisable()
    {
        playerInput.Disable();
        EventManager.DisableMovement -= EventManagerOnDisableMovement;
        EventManager.EnableMovement -= EventManagerOnEnableMovement;
    }

    private void EventManagerOnEnableMovement()
    {
        playerInput.Movement.Enable();
    }

    private void EventManagerOnDisableMovement()
    {
        playerInput.Movement.Disable();
    }

   
    
}
