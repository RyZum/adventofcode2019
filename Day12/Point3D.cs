﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Day12
{
    public class Point3D
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public int Energy
        {
            get => Math.Abs(X) + Math.Abs(Y) + Math.Abs(Z);
        }

        public static Point3D operator -(Point3D point)
            => new Point3D
            {
                X = -point.X,
                Y = -point.Y,
                Z = -point.Z,

            };

        public static Point3D operator +(Point3D point1, Point3D point2)
            => new Point3D
            {
                X = point1.X + point2.X,
                Y = point1.Y + point2.Y,
                Z = point1.Z + point2.Z,

            };

        public static Point3D operator -(Point3D point1, Point3D point2)
            => new Point3D
            {
                X = point1.X - point2.X,
                Y = point1.Y - point2.Y,
                Z = point1.Z - point2.Z,

            };

        public static Point3D Sign(Point3D point)
        {
            return new Point3D()
            {
                X = Math.Sign(point.X),
                Y = Math.Sign(point.Y),
                Z = Math.Sign(point.Z)
            };
        }

        public override string ToString()
        {
            return $"<x={X}, y={Y}, z={Z}>";
        }
    }
}
