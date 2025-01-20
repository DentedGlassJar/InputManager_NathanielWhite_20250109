using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputManagerScript;

public class ObjectListener : MonoBehaviour
{
    // --VARIABLES--

    // Variables used for getting the cube and cylinder gameObjects
    public GameObject cubeObject; 
    public GameObject cylinderObject;

    // Variable used as a reference for the meshRenderer of the sphere gameObject
    public MeshRenderer sphereRenderer;

    // Variables used for getting the transparent materials
    public Material matTransparent;



    // --METHODS--

    // This is called when the behaviour is enabled or active
    public void OnEnable()
    {
        Actions.jumpEvent += CubeMethod;
        Actions.growEvent += CylinderMethod;
        Actions.disappearEvent += SphereMethod;
    }

    // This is called when the behaviour is disabled or inactive
    public void OnDisable()
    {
        Actions.jumpEvent -= CubeMethod;
        Actions.growEvent -= CylinderMethod;
        Actions.disappearEvent -= SphereMethod;
    }

    private void CubeMethod()
    {
        // Changes the position the cube is in
        cubeObject.transform.position = new Vector3(-6f, 4f, -6f);
    }

    private void CylinderMethod()
    {
        // Changes the size the Cylinder is
        cylinderObject.transform.localScale = new Vector3(2f, 2f, 2f);
    }

    private void SphereMethod()
    {
        // This will change the material that sphere has to be transparent, making it "disappear"
        sphereRenderer.material = matTransparent;
    }
}
