using UnityEngine;
using System.Collections;

public class ChangeCursor : MonoBehaviour {

    [SerializeField]
    private Texture2D bullsEyeCursor;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start ()
    {
        Cursor.SetCursor(bullsEyeCursor , hotSpot , cursorMode);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
