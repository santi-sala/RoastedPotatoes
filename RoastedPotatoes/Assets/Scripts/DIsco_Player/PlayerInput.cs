using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance { get; private set; }

    public event EventHandler OnLeftPressed;
    public event EventHandler OnInteractionPressed;
    public event EventHandler OnRightPressed;
    public event EventHandler OnUpPressed;
    public event EventHandler OnDownPressed;

    [SerializeField] private GameObject _leftButton;
    [SerializeField] private Sprite _leftSpriteDefault;
    [SerializeField] private Sprite _leftSpritePressed;
    private SpriteRenderer _leftSpriteRenderer;

    [SerializeField] private GameObject _downButton;
    [SerializeField] private Sprite _downSpriteDefault;
    [SerializeField] private Sprite _downSpritePressed;
    private SpriteRenderer _downSpriteRenderer;

    [SerializeField] private GameObject _rightButton;
    [SerializeField] private Sprite _rightSpriteDefault;
    [SerializeField] private Sprite _rightSpritePressed;
    private SpriteRenderer _rightSpriteRenderer;

    [SerializeField] private GameObject _upButton;
    [SerializeField] private Sprite _upSpriteDefault;
    [SerializeField] private Sprite _upSpritePressed;
    private SpriteRenderer _upSpriteRenderer;

    private DefaultInput _playerActions;




    void Awake()
    {
        Instance = this;
        _playerActions = new DefaultInput();
        _playerActions.Enable();
    }
    private void Start()
    {
        _playerActions.ControlScheme.Movement_Left.started += Movement_Left_started;
        _leftSpriteRenderer  = _leftButton.GetComponent<SpriteRenderer>();

        _playerActions.ControlScheme.Movement_Down.started += Movement_Down_started;
        _downSpriteRenderer  = _downButton.GetComponent<SpriteRenderer>();

        _playerActions.ControlScheme.Movement_Right.started += Movement_Right_started;
        _rightSpriteRenderer = _rightButton.GetComponent<SpriteRenderer>();
        
        _playerActions.ControlScheme.Movement_Up.started += Movement_Up_started;
        _upSpriteRenderer = _upButton.GetComponent<SpriteRenderer>();

        _playerActions.ControlScheme.Interaction.performed += Interaction_performed;
    }
    private void Movement_Left_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _leftSpriteRenderer.sprite = _leftSpritePressed;
        OnLeftPressed?.Invoke(this, EventArgs.Empty);
    }

    private void Movement_Down_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _downSpriteRenderer.sprite = _downSpritePressed;
        OnDownPressed?.Invoke(this, EventArgs.Empty);
    }

    private void Movement_Up_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _upSpriteRenderer.sprite = _upSpritePressed;
        OnUpPressed?.Invoke(this, EventArgs.Empty);
    }

    private void Movement_Right_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _rightSpriteRenderer.sprite = _rightSpritePressed;
        OnRightPressed?.Invoke(this, EventArgs.Empty);
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

        if( _playerActions.ControlScheme.Movement_Down.WasReleasedThisFrame()) 
        { 
            _downSpriteRenderer.sprite= _downSpriteDefault;
        }

        if (_playerActions.ControlScheme.Movement_Right.WasReleasedThisFrame())
        {
            _rightSpriteRenderer.sprite = _rightSpriteDefault;
        }

        if (_playerActions.ControlScheme.Movement_Up.WasReleasedThisFrame())
        {
            _upSpriteRenderer.sprite = _upSpriteDefault;
        }
    }
}
