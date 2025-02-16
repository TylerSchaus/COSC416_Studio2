using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] InputManager inputManager;
    [SerializeField] private Transform ballAnchor;
    [SerializeField] private Transform launchIndicator;

    private bool isBallLaunched;
    private Rigidbody ballRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
        ballRB = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        inputManager.onSpacePressed.AddListener(LaunchBall);

        ResetBall(); 
    }

    private void LaunchBall()
    {

        if (isBallLaunched)
        {
            return;
        }

        isBallLaunched = true;

        transform.parent = null;
   
        ballRB.isKinematic = false;

        ballRB.AddForce(launchIndicator.forward * force, ForceMode.Impulse);

        launchIndicator.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBall()
    {
        isBallLaunched=false;

        ballRB.isKinematic = true;

        launchIndicator.gameObject.SetActive(true);
        transform.parent = ballAnchor; 
        transform.localPosition= Vector3.zero;
    }
}
