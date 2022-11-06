using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cuboid : Shape3D
    {
        private float _width, _height, _length;
        private Vector3 _center;
        private bool _isCube = false;

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _width = size.X;
            _height = size.Y;
            _length = size.Z;

            if (size.X == size.Y && size.Y == size.Z) _isCube = true;

        }

        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _width = width;
            _height = width;
            _length = width;

            _isCube = true;

        }
        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);

        public bool IsCube => _height == _width; 

        public override float Area => (float)((2 * _length * _width) + (2 * _length * _height) + (2 * _height * _width));

        public override float Volume
        {
            get
            {
                if (_isCube == true)
                {
                    return (float)(Math.Pow(_length, 3));
                }
                else
                {
                    return (float)(_width * _height * _length);
                }
            }
        }

        public override string ToString()
        {
            if (_isCube == true)
            {
                return $"cube @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}) w = {_width:0.0}, h = {_height:0.0}, l = {_length:0.0}";
            }
            else
            {
                return $"cuboid @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}) w = {_width:0.0}, h = {_height:0.0}, l = {_length:0.0}";
            }
        }
    }
}
