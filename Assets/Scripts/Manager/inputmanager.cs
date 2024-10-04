/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputmanager : MonoBehaviour
{
    public gamedirector gamedirector;
    public Vector2 initialMousePos;
    public Vector2 dragVector;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            initialMousePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 curMousePos = Input.mousePosition;
            dragVector = curMousePos - initialMousePos;
            dragVector.x = Mathf.Clamp(dragVector.x, -100, 100);
            dragVector.y = Mathf.Clamp(dragVector.y, -100, 100);

            // Dragged metodunu çağırarak player'ı hareket ettir
            gamedirector.Dragged(dragVector);

            // Her hareketten sonra dragVector'ü sıfırlayın, böylece sadece hareket olduğu sürece geçerli olur
            initialMousePos = curMousePos;
        }
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputmanager : MonoBehaviour
{
    public gamedirector gamedirector;

    void Update()
    {
        // ASDW tuşları ile hareket vektörü belirlenir
        Vector2 inputVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (inputVector != Vector2.zero)
        {
            gamedirector.Dragged(inputVector);
        }
    }
}
