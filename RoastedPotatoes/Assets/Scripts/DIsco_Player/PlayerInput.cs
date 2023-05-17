using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance { get; private set; }

    public event EventHandler OnLeftPressed;
    public event EventHandler OnInteractionPressed;
    public event EventHandler OnRightPressed;
    //public event EventHandler OnUpPressed;
    //public event EventHandler OnDownPressed;

    [SerializeField] private GameObject _upButton;
    [SerializeField] private GameObject _downButton;

    [SerializeField] private GameObject _leftButton;
    [SerializeField] private Sprite _leftSpriteDefault;
    [SerializeField] private Sprite _leftSpritePressed;

    [SerializeField] private GameObject _rightButton;
    [SerializeField] private Sprite _rightSpriteDefault;
    [SerializeField] private Sprite _rightSpritePressed;


    private DefaultInput _playerActions;

    private SpriteRenderer _leftSpriteRenderer;
    private SpriteRenderer _rightSpriteRenderer;



    void Awake()
    {
        Instance = this;
        _playerActions = new DefaultInput();
        _playerActions.Enable();
    }
    private void Start()
    {
        _playerActions.ControlScheme.Movement_Left.started += Movement_Left_started;
        _playerActions.ControlScheme.Movement_Right.started += Movement_Right_started;
        _playerActions.ControlScheme.Interaction.performed += Interaction_performed;
        
        _leftSpriteRenderer  = _leftButton.GetComponent<SpriteRenderer>();
        _rightSpriteRenderer = _rightButton.GetComponent<SpriteRenderer>();

    }

    private void Movement_Right_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _rightSpriteRenderer.sprite = _rightSpritePressed;
    }


    private void Movement_Left_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _leftSpriteRenderer.sprite = _leftSpritePressed;
        OnLeftPressed?.Invoke(this, EventArgs.Empty);
    }
    private void Interaction_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractionPressed?.Invoke(this, EventArgs.Empty);
    }
    
    void Update()
    {

       if( _playerActions.ControlScheme.Movement_Left.WasReleasedThisFrame())
        {        
            _leftSpriteRenderer.sprite = _leftSpriteDefault;
        }
        
    }
}
