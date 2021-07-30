using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galery : MonoBehaviour
{
    #region variables

    float umfang;
    float radius=8f;
    float anzahlNFTs=8;
    float _angle;
    private Vector3 _centre;

    [SerializeField]
    GameObject NFTGameObject;
    [SerializeField]
    GameObject Sphere;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _centre = new Vector3(0,0,0);

        InstantiateNFTsinCircle();
    }

    // Update is called once per frame
    public void InstantiateNFTsinCircle()
    {
        for (float a = anzahlNFTs; a > 0; a--)
        {
            _angle = 360f / anzahlNFTs;
            Quaternion rotation = Quaternion.AngleAxis(a*_angle, Vector3.up); 
            Vector3 direction = rotation * Vector3.right;

            Vector3 position = _centre + (direction*radius);
            var newObject = Instantiate(NFTGameObject,position,rotation);
            newObject.SetActive(true);
        }


    }
}
