using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickableCircle : MonoBehaviour
{

    private void OnMouseDrag()
    {
        transform.localScale += new Vector3(0.025F, 0.025F, 0);
    }
}
