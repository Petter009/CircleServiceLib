using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CircleServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CircleService : ICircleService
    {
        public double CalcCirumference(double radius)
        {
            return Math.PI*(radius*2);
        }

        public double CalcDiameter(double radius)
        {
            return radius * 2; 
        }
    }
}
