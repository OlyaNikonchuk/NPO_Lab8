﻿using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType Type;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int MaxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, MaxLoadCapacity)
        {
            Type = type;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   Type == plane.Type;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            return hashCode;
        }

        public MilitaryType PlaneTypeIs()
        {
            return Type;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}", ", type=" + Type + '}');
        }        
    }
}
