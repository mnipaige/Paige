using UnityEngine;

namespace XNode.Examples.MathNodes {
    public class Vector : XNode.Node {
        [Input] public float x, y, z;
        [Output] public Vector3 vector3;
        [Output] public Vector2 vector2;

        public override object GetValue(XNode.NodePort port) {
            if(port.fieldName == "vector3")
            {
                vector3.x = GetInputValue<float>("x", this.x);
                vector3.y = GetInputValue<float>("y", this.y);
                vector3.z = GetInputValue<float>("z", this.z);
                return vector3;
            }
            else if(port.fieldName == "vector2")
            {
                vector2.x = GetInputValue<float>("x", this.x);
                vector2.y = GetInputValue<float>("y", this.y);
                return vector2;
            }
            return null;
        }
    }
}