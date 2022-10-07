using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Sphere : Shape3D
    {
        private float _radius;
        private Vector3 _center;

        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
        }
        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);
        public override float Area => (float)(4 * Math.PI * (Math.Pow(_radius, 2)));

        public override float Volume => (float)(4 * Math.PI * (Math.Pow(_radius, 3)) / 3);

        public override string ToString()
        {
            return $"sphere @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): r = {_radius:0.0}";
        }

    }
}
