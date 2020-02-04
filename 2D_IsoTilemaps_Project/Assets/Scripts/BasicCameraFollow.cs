//using UnityEngine;
//using System.Collections;


//public class BasicCameraFollow : MonoBehaviour
//{
//	private Camera camera = new Camera();

//	private Vector3 startingPosition;
//	public Transform followTarget;
//	private Vector3 targetPos;
//	public float moveSpeed;

//	public bool isZoomed = true;

//	void Start()
//	{
//		startingPosition = transform.position;
//	}

//	void Update()
//	{
//		if(transform.GetComponent<Camera>().orthographicSize > 2 && isZoomed)
//			ZoomIn();

//		if (followTarget != null)
//		{
//			targetPos = new Vector3(followTarget.position.x, followTarget.position.y, transform.position.z);
//			Vector3 velocity = (targetPos - transform.position) * moveSpeed;
//			transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, 1.0f, Time.deltaTime);
//		}


//	}

//	public void ZoomIn()
//	{
//		float CameraZoom = 2;

//		float CameraZoomDifference;
//		CameraZoomDifference = CameraZoom - this.transform.GetComponent<Camera>().orthographicSize;
//		float CAmeraZoomSpeed = 1f;

//		transform.GetComponent<Camera>().orthographicSize += CameraZoomDifference * CAmeraZoomSpeed * Time.deltaTime;

//		if (CameraZoomDifference > 0)
//		{
//			if (transform.GetComponent<Camera>().orthographicSize > CameraZoom)
//			{
//				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
//			}
//		}
//		else
//		{
//			if (transform.GetComponent<Camera>().orthographicSize < CameraZoom)
//			{
//				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
//			}
//		}
//	}


//	public void ZoomOut()
//	{
//		float CameraZoom = 4;

//		float CameraZoomDifference;
//		CameraZoomDifference = CameraZoom - transform.GetComponent<Camera>().orthographicSize;
//		float CAmeraZoomSpeed = 0.5f;

//		transform.GetComponent<Camera>().orthographicSize += CameraZoomDifference * CAmeraZoomSpeed * Time.deltaTime;

//		if (CameraZoomDifference > 0)
//		{
//			if (transform.GetComponent<Camera>().orthographicSize > CameraZoom)
//			{
//				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
//			}
//		}
//		else
//		{
//			if (transform.GetComponent<Camera>().orthographicSize < CameraZoom)
//			{
//				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
//			}
//		}
//	}

//}


using UnityEngine;
using System.Collections;


public class BasicCameraFollow : MonoBehaviour
{
	private Camera camera = new Camera();

	private Vector3 startingPosition;
	public Transform followTarget;
	private Vector3 targetPos;
	public float moveSpeed;

	public bool isZoomed = false;

	void Start()
	{
		startingPosition = transform.position;
	}

	void Update()
	{

		if (transform.GetComponent<Camera>().orthographicSize < 5 && !isZoomed)
			ZoomOut();

		if (followTarget != null)
		{
			targetPos = new Vector3(followTarget.position.x, followTarget.position.y, transform.position.z);
			Vector3 velocity = (targetPos - transform.position) * moveSpeed;
			transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, 1.0f, Time.deltaTime);
		}


	}

	public void ZoomIn()
	{
		float CameraZoom = 2;

		float CameraZoomDifference;
		CameraZoomDifference = CameraZoom - this.transform.GetComponent<Camera>().orthographicSize;
		float CAmeraZoomSpeed = 1f;

		transform.GetComponent<Camera>().orthographicSize += CameraZoomDifference * CAmeraZoomSpeed * Time.deltaTime;

		if (CameraZoomDifference > 0)
		{
			if (transform.GetComponent<Camera>().orthographicSize > CameraZoom)
			{
				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
			}
		}
		else
		{
			if (transform.GetComponent<Camera>().orthographicSize < CameraZoom)
			{
				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
			}
		}
	}


	public void ZoomOut()
	{
		float CameraZoom = 4;

		float CameraZoomDifference;
		CameraZoomDifference = CameraZoom - transform.GetComponent<Camera>().orthographicSize;
		float CAmeraZoomSpeed = 0.5f;

		transform.GetComponent<Camera>().orthographicSize += CameraZoomDifference * CAmeraZoomSpeed * Time.deltaTime;

		if (CameraZoomDifference > 0)
		{
			if (transform.GetComponent<Camera>().orthographicSize > CameraZoom)
			{
				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
			}
		}
		else
		{
			if (transform.GetComponent<Camera>().orthographicSize < CameraZoom)
			{
				transform.GetComponent<Camera>().orthographicSize = CameraZoom;
			}
		}
	}

}




