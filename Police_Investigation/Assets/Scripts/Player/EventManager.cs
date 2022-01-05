    using System;
    using UnityEngine;

    public class EventManager : MonoBehaviour
    {
        public static EventManager instance;
        
        public static event Action DisableMovement;
        public static event Action EnableMovement;
        
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
        }
        
        #region Events
    
        public static void OnDisablePlayerMovement()
        {
            DisableMovement?.Invoke();
        }
        
        public static void OnEnableMovement()
        {
            EnableMovement?.Invoke();
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        #endregion


        
    }
