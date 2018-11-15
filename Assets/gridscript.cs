using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridscript : MonoBehaviour {

    public GameObject Tower;
    private GameObject TowerTest;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    private bool CanPlaceTower()
    {
        return TowerTest == null;
    }
    //1
    void OnMouseUp()
    {
        //2
        if (CanPlaceTower())
        {
            //3
            TowerTest = (GameObject)
              Instantiate(Tower, transform.position, Quaternion.identity);
        }
    }

}
//public class gridscript : MonoBehaviour
//{
//    public GameObject Tower;

//    // Update is called once per frame
//    void Update()
//    {
//    }
//    private bool CanPlaceTower()
//    {
//        return Tower == null;
//    }
//    //1
//    void OnMouseUp()
//    {
//        //2
//        if (CanPlaceTower())
//        {
//            //3
//            Tower = (GameObject)
//              Instantiate(Tower, transform.position, Quaternion.identity);
//        }
//    }

//}
