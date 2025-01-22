using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using static InputManagerScript;

public class ObjectListener : MonoBehaviour
{
    // --VARIABLES--

    // Variables used for getting the cube and cylinder gameObjects
    public GameObject cubeObject; 
    public GameObject cylinderObject;

    // Variable used as a reference for the meshRenderer of the sphere gameObject
    public MeshRenderer sphereRenderer;

    // Variable used as a reference for the animation of the cube
    public Animator cubeAnimator;

    // Variables used for getting the materials
    public Material matGreen;
    public Material matYellow;
    public Material matTransparent;


    // --METHODS--

    private void Start()
    {
        // Makes it so the animation of the cube doesn't play
        cubeAnimator.enabled = false;
    }

    // This is called when the behaviour is enabled or active
    public void OnEnable()
    {
        // Cube
        Actions.jumpEvent += JumpMethod;
        Actions.spinEvent += SpinMethod;
        Actions.fallEvent += FallMethod;

        // Cylinder
        Actions.squashEvent += SquashMethod;
        Actions.stretchEvent += StretchMethod;
        Actions.turnToNormalEvent += TurnToNormalMethod;

        // Sphere
        Actions.greenEvent += GreenMethod;
        Actions.yellowEvent += YellowMethod;
        Actions.disappearEvent += DisappearMethod;
    }

    // This is called when the behaviour is disabled or inactive
    public void OnDisable()
    {
        // Cube
        Actions.jumpEvent -= JumpMethod;
        Actions.spinEvent -= SpinMethod;
        Actions.fallEvent -= FallMethod;

        // Cylinder
        Actions.squashEvent -= SquashMethod;
        Actions.stretchEvent -= StretchMethod;
        Actions.turnToNormalEvent -= TurnToNormalMethod;

        // Sphere
        Actions.greenEvent -= GreenMethod;
        Actions.yellowEvent -= YellowMethod;
        Actions.disappearEvent -= DisappearMethod;
    }


    // Methods used for the Cube gameObject

    private void JumpMethod()
    {
        // Changes the position the cube is in
        cubeObject.transform.position = new Vector3(-6f, 4f, -6f);
    }

    private void SpinMethod()
    {
        // Begins playing the animation of the cube
        cubeAnimator.enabled = true;
    }

    private void FallMethod()
    {
        // Stops playing the animation
        cubeAnimator.enabled = false;
        
        // Resets the position of the cube
        cubeObject.transform.position = new Vector3(-6f, 1f, -6f);
    }

    // Methods used for the Cylinder gameObject
    private void SquashMethod()
    {
        // Changes the size the Cylinder is
        cylinderObject.transform.localScale = new Vector3(1.5f, 0.25f, 1.5f);
    }

    private void StretchMethod()
    {
        // Changes the size the Cylinder is
        cylinderObject.transform.localScale = new Vector3(0.5f, 1f, 0.5f);
    }

    private void TurnToNormalMethod()
    {
        // Reverts the Cylinder to it's original size
        cylinderObject.transform.localScale = new Vector3(1f, 0.5f, 1f);
    }

    // Methods used for the Sphere gameObject

    // When context is started
    private void GreenMethod()
    {
        // This will change the material the sphere has to be green, changing it's color
        sphereRenderer.material = matGreen;
    }
    
    // When context is performed
    private void YellowMethod()
    {
        // This will change the material the sphere has to be yellow, changing it's color
        sphereRenderer.material = matYellow;
    }

    // When context is canceled
    private void DisappearMethod()
    {
        // This will change the material that sphere has to be transparent, making it "disappear"
        sphereRenderer.material = matTransparent;
    }
}
