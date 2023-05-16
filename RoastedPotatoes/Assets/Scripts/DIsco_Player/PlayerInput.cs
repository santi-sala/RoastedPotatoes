using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance { get; private set; }
    public event EventHandler OnLeftPressed;
    //public event EventHandler OnRightPressed;
    //public event EventHandler OnUpPressed;
    //public event EventHandler OnDownPressed;

    [SerializeField] private GameObject _left;
    private DefaultInput _playerActions;
    private SpriteRenderer _leftColor;
   

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        _playerActions = new DefaultInput();
        _playerActions.Enable();
    }
    private void Start()
    {
        _leftColor  = _left.GetComponent<SpriteRenderer>();
        //_playerActions.ControlScheme.Movement_Left.performed += Movement_Left_performed;
        _playerActions.ControlScheme.Movement_Left.started += Movement_Left_started;
        
    }

   
    
    private void Movement_Left_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _leftColor.color = new Color(0, 0, 0);
        //Debug.Log("STARTED");
        OnLeftPressed?.Invoke(this, EventArgs.Empty);

        //_playerActions.ControlScheme.Movement_Left.WasReleasedThisFrame
    }
    
    /*
    private void Movement_Left_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
        _leftColor.color = new Color(255, 0, 0);
        Debug.Log("Performed");
    }
    */

    // Update is called once per frame
    void Update()
    {

       if( _playerActions.ControlScheme.Movement_Left.WasReleasedThisFrame())
        {
            //Debug.Log("sup");            
            _leftColor.color = new Color(255, 0, 0);
        }
        /*
        if (_playerActions.ControlScheme.Movement_Left.WasReleasedThisFrame() )
        {
            //Debug.Log("sup!!");
            _leftColor.color = new Color(0,0,0);
            OnLeftPressed?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            _leftColor.color = new Color(255, 0, 0);
        } 
        */
    }
}
