using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exemple : MonoBehaviour
{
    public Mesh Mesh;
    public Material Material;

    public void OnPostRender()
    {
        Material.SetPass(0);
        Graphics.DrawMeshNow(Mesh, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void Start() 
    {
        //Material = new Material(Shader.Find("Unlit/Color"));
        //Material.color = Color.magenta;
        Mesh = new Mesh();


        Vector3[] vertices = new Vector3[]
        {
            new Vector3(1, 0, 0), // 0
            new Vector3(0, 0, 0), // 1
            new Vector3(0, 1, 0), // 2
            new Vector3(1, 1, 0), // 3
            new Vector3(0, 1, 1), // 4
            new Vector3(1, 1, 1), // 5
            new Vector3(1, 0, 1), // 6
            new Vector3(0, 0, 1)  // 7


        };

        int[] triangles = new int[]
        {
            0, 1, 2,
            0, 2, 3,

            2, 4, 3,
            4, 5, 3,

            0, 3, 6,
            6, 3, 5
        };



        Color[] colors = new Color[]
        {
            //Color.red,
            //Color.green,
            //Color.blue,
            //Color.yellow,
            //Color.cyan,
            //Color.magenta,
            //Color.white,
            //Color.black,

            //Color.red,
            //Color.white,
            //Color.green,
            //Color.yellow,
            //Color.cyan,
            //Color.black,
            //Color.magenta,
            //Color.blue

            //Color.white,
            //Color.red,
            //Color.red,
            //Color.red,
            //Color.red,
            //Color.red,
            //Color.red,
            //Color.red,

            new (1, 0, 0), // 0
            new (0, 0, 0), // 1
            new (0, 1, 0), // 2
            new (1, 1, 0), // 3
            new (0, 1, 1), // 4
            new (1, 1, 1), // 5
            new (1, 0, 1), // 6
            new (0, 0, 1)  // 7
        };







        Mesh.vertices = vertices;
        Mesh.colors = colors;
        Mesh.triangles = triangles;

    }
}
