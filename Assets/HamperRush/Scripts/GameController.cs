using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class GameController : MonoBehaviour
{
	public GameObject housePrefab;
	private List<Vector3> edgePoint = new List<Vector3>();
	public GameObject hamperPrefab;
	private List<Vector3> houseList = new List<Vector3>();
	public Camera FirstPersonCamera;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		DropHamper();
	}

	public void SpawnHouses(DetectedPlane plane)
	{
		plane.GetBoundaryPolygon(edgePoint);
		foreach (Vector3 p in edgePoint)
		{
			if (houseList.Count != 0)
			{
				bool close = false;
				foreach (Vector3 housePos in houseList)
				{
					if (Vector3.Distance(p, housePos) < 0.2f)
					{
						close = true;
					}
				}
				if (!close)
				{
					GameObject houseTemp;
					houseTemp = Instantiate(housePrefab, p, Quaternion.identity);
					houseList.Add(houseTemp.transform.position);
				}
			}
			else
			{
				GameObject houseTemp;
				houseTemp = Instantiate(housePrefab, p, Quaternion.identity);
				houseList.Add(houseTemp.transform.position);
			}
		}
	}

	public void DropHamper()
	{
#if !UNITY_EDITOR
	if (Input.GetTouch(0).phase == TouchPhase.Began)
#endif
#if UNITY_EDITOR
		if (Input.GetMouseButtonDown(0))
#endif
		{
			GameObject hamper;
			hamper = Instantiate(hamperPrefab, FirstPersonCamera.transform.position, Quaternion.identity);
			Debug.Log("Dropped hamper");
		}
	}

}
