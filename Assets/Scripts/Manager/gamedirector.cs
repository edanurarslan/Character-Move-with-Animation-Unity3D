/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamedirector : MonoBehaviour
{
    public player player;

    public void Dragged(Vector2 dragVector)
    {
        player.MovePlayer(dragVector);
    }

}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamedirector : MonoBehaviour
{
    public player player;

    public void Dragged(Vector2 inputVector)
    {
        player.MovePlayer(inputVector);
    }
}
