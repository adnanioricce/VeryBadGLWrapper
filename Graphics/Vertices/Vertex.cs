﻿using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace GLWrapper.Graphics.Vertices
{
    /// <summary>
    /// Vertex holding only a Position Vector. Has size of 12 bytes
    /// </summary>
    public struct Vertex
    {
        public const int Size = (3 + 3) * 4;
        public const int PositionStride = 3 * sizeof(float);
        public const int NormalCoordinateStride = 3 * sizeof(float);
        public Vector3 Position;
        public Vector3 Normal;
        public Vertex(Vector3 position)
        {
            Position = position;
            Normal = Vector3.UnitY;
        }
        public Vertex(Vector3 position, Vector3 normal) : this(position)
        {
            Normal = normal;
        }
        public Vertex(ColoredVertex vertex)
        {
            Position = vertex.Position;
            Normal = Vector3.UnitY;
        }
        public Vertex(ColoredTexturedVertex vertex)
        {
            Position = vertex.Position;
            Normal = Vector3.UnitY;
        }
        
    }
}
