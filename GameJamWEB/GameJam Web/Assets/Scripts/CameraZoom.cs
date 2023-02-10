using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CameraZoom : MonoBehaviour
{
    [SerializeField] Camera playerCam;
    float touchPrevPosDifference;
    float touchCurPosDifference;
    float zoomModifer;
    Vector2 firstTouchPrevPos;
    Vector2 secoundTouchPrevPos;
    [SerializeField] float zoomModifierSpeed = 0.3f;
    [SerializeField] TMP_Text testdisplay;

    void Start()
    {
        playerCam = GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secoundTouch = Input.GetTouch(1);
            firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
            secoundTouchPrevPos = secoundTouch.position - secoundTouch.deltaPosition;
            touchPrevPosDifference = (firstTouchPrevPos -secoundTouchPrevPos).magnitude;
            touchCurPosDifference = (firstTouch.position - secoundTouch.position).magnitude;
            zoomModifer = (firstTouch.deltaPosition - secoundTouch.deltaPosition).magnitude * zoomModifierSpeed;
            if(touchPrevPosDifference > touchCurPosDifference)
            {
                playerCam.orthographicSize += zoomModifer;
            }
            if(touchPrevPosDifference < touchCurPosDifference)
            {
                playerCam.orthographicSize -= zoomModifer;
            }

            playerCam.orthographicSize = Mathf.Clamp(playerCam.orthographicSize,2f,10f);
            testdisplay.SetText(playerCam.gameObject.transform.position + "X" + firstTouch.position);
        }
    }
}
