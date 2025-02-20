﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeSafe.Scripts
{
    // enums ---------------------------------------------------------------------------------------------------------
    public enum Direction { Up, Down, Left, Right };

    public enum TileObjectType { Player, Pushable }

    public enum TileInteractableType { PressurePlate }


    // classes -------------------------------------------------------------------------------------------------------
    public class TileData
    {
        public enum GroundType { Grass, Water } // @TODO: CLiff(straight, etc.), Rock, Elevated, ...
        public enum StructureType { None, Wall_Straight, Wall_Sideways, Wall_Corner, PressurePlate } // @TODO: Door
        public enum ObjectType { Crate, Plant }

        public GroundType    groundType;
        public StructureType structureType;
        public ObjectType[]  objectTypes;

        public TileData(GroundType _groundType, StructureType _structureType, ObjectType[] _objectTypes)
        {
            this.groundType     = _groundType;
            this.structureType  = _structureType;
            this.objectTypes    = _objectTypes;
        }
    }
}
