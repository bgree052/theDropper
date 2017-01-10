using UnityEngine;
using System.Collections;

//Found on http://coffeebreakcodes.com/drag-object-with-mouse-unity3d/ but all comments are mine for explanation. 


//This explanation might also help you understand some stuff here, which isn't explained all that well in Unity Docs:
// https://www.reddit.com/r/Unity3D/comments/2b4k88/what_exactly_is_world_space_and_screen_space/



public class DragObject : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;

    //When you first click the mouse button...AND NOTE THAT THIS MUST BE OVER A COLLIDER (or a GUI thingy in another context).
    void OnMouseDown()
    {
        //This converts the world position of the object (which is in *3D*) to a point on the screen (which is *2D*).
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        /*This determines the distance between where you clicked the mouse and where your object is.
        - 1st, it takes the objects position (in 3D space).
        - 2nd, it translates where you clicked on the screen (which is in *2D* space) to a worldspace co-ord (which is in *3D*). 
            In this 2nd bit, the x and y is from your mousePosition, and the 'z' is taken the 'z' value you worked out in screenPoint, so that they have the same z value.
            z here is the depth/distance away from the camera.
        */
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        //Why do you need the offset? Because then you can click on any part of the collider and still drag the object. If you didn't have the offset, the object would jump to your cursor position.
        
    }

    //...so when you then drag the mouse...
    void OnMouseDrag()
    {
        //Grabs where the mouse cursor is, using the screenPoint.z value to provide the depth like before.
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        //Converts this mouse position for the screen into a co-ord in the world for the object to use.
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;

        //Move our object to that position.
        transform.position = cursorPosition;
    }



}

