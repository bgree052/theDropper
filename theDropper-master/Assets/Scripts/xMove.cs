using UnityEngine;
using System.Collections;

public class xMove : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;

    
    void OnMouseDown()
    {
    
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    
    }

    
    void OnMouseDrag()
    {
    
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

    
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;

        // transform.position = cursorPosition;
        transform.position = new Vector3(cursorPosition.x, transform.position.y, transform.position.z);

        //Above, I've put in the original line from DragObject and commented it out. You can see the (minor) changes I needed to make to constrain the object in the x-axis.
        //You can set the whole transform.position (with a Vector3), but you can't directly assign the x, y, z (i.e. transform.position.x etc.) individually. So all I did was use a Vector3 and the y and z values are provided by the existing co-ordinates of the object. 
        //Job done.
    }



}
