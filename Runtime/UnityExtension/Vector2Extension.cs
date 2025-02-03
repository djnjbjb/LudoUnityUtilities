using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LudoUtilities.Extension
{
    public class Vector2Extension 
    {
        /// <summary>
        /// 点到直线，距离最近的点
        /// 其实就是点到直线作垂线的垂足
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="direction"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        static public Vector2 FromPointToLine_FindNearestPoint(Vector2 origin, Vector2 direction, Vector2 point)
        {
            direction.Normalize();
            Vector2 lhs = point - origin;

            float dotP = Vector2.Dot(lhs, direction);
            return origin + direction * dotP;
        }

        /// <summary>
        /// 点到线段，距离最近的点
        /// 可能是点到直线垂线的垂足，也可能是端点
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="end"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        static public Vector2 FromPointToLineSegment_FindNearestPoint(Vector2 origin, Vector2 end, Vector2 point)
        {
            //Get heading
            Vector2 heading = (end - origin);
            float magnitudeMax = heading.magnitude;
            heading.Normalize();

            //Do projection from the point but clamp it
            Vector2 lhs = point - origin;
            float dotP = Vector2.Dot(lhs, heading);
            dotP = Mathf.Clamp(dotP, 0f, magnitudeMax);
            return origin + heading * dotP;
        }
    }
}
